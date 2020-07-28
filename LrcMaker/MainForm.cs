using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace LrcMaker
{
    public partial class MainForm : Form, IDisposable
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_writeText_Click(object sender, EventArgs e)
        {
            RawLyricWriter rlw = new RawLyricWriter(GetLyricText());
            rlw.ShowDialog();

            SetLyricText(rlw.Base);
        }

        private void SetLyricText(string str)
        {
            lbox_lrc.Items.Clear();
            string[] datas = str.Split('\n');

            foreach (var d in datas)
            {
                lbox_lrc.Items.Add(d);
            }

            lbox_lrc.ClearSelected();
            lbox_lrc.SelectedIndex = 0;
        }

        private string GetLyricText(string escape = "\n")
        {
            List<string> str = new List<string>();
            foreach (string d in lbox_lrc.Items)
            {
                str.Add(d);
            }
            return string.Join(escape, str);
        }

        private void saveLrcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd_lrc.ShowDialog() != DialogResult.OK)
                return;

            File.WriteAllText(sfd_lrc.FileName, GetLyricText("\n"), Encoding.UTF8);
        }

        IWaveSource waveSource = null;
        ISoundOut soundOut = null;

        private void openAudioFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd_music.ShowDialog() != DialogResult.OK)
                return;

            waveSource = CodecFactory.Instance.GetCodec(ofd_music.FileName)
                .ToSampleSource()
                .ToStereo()
                .ToWaveSource();

            soundOut = GetSoundOut();
            soundOut.Initialize(waveSource);
            tbar_pos.Maximum = (int)waveSource.GetLength().TotalMilliseconds;

            sfd_lrc.FileName = Path.GetFileNameWithoutExtension(ofd_music.FileName) + ".lrc";
        }

        private void UnloadAudioFile()
        {
            if (waveSource != null)
                waveSource.Dispose();

            if (soundOut != null)
                soundOut.Dispose();
        }

        private ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (soundOut != null)
                soundOut.Play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (soundOut != null)
                soundOut.Pause();
        }

        private void timer_setPos_Tick(object sender, EventArgs e)
        {
            if (waveSource == null) return;
            if (soundOut == null) return;

            if (soundOut.PlaybackState != PlaybackState.Playing) return;

            tbar_pos.Value = (int)waveSource.GetPosition().TotalMilliseconds;

            // Lyric Sync
            for (int i = 0; i < lbox_lrc.Items.Count; i++)
            {
                string txt = (string)lbox_lrc.Items[i];
                var time = GetLrcTimeCode(txt);
                if (!time.HasValue) continue;

                if (time.Value >= waveSource.GetPosition())
                {
                    lbl_lrc_p.Text = (i > 1 ? GetPureLyric((string)lbox_lrc.Items[i - 2]) : string.Empty);
                    lbl_lrc_c.Text = (i > 0 ? GetPureLyric((string)lbox_lrc.Items[i - 1]) : "Start of File");
                    lbl_lrc_n.Text = GetPureLyric(txt);

                    return;
                }
            }

        }

        private void btn_setTime_Click(object sender, EventArgs e)
        {
            if (waveSource == null) return;
            if (lbox_lrc.SelectedIndex == -1) return;

            string orig = (string)lbox_lrc.SelectedItem;
            if (CheckLyricSet(orig))
            {
                orig = GetPureLyric(orig);
            }
            
            orig = GetLrcTimeCode(waveSource.GetPosition()) + orig;

            lbox_lrc.Items[lbox_lrc.SelectedIndex] = orig;

            while (lbox_lrc.Items.Count > lbox_lrc.SelectedIndex + 1)
            { 
                lbox_lrc.SelectedIndex++;

                if ((string)lbox_lrc.SelectedItem != string.Empty)
                    break;
            }
        }

        private bool CheckLyricSet(string str)
        {
            return Regex.IsMatch(str, @"^\[\d+:\d\d((:|\.)\d\d)?\]");
        }
        
        private string GetPureLyric(string str)
        {
            if (!CheckLyricSet(str)) return str;
            return Regex.Replace(str, @"^\[\d+:\d\d((:|\.)\d\d)?\](?<lrc>.+)$", "${lrc}");
        }

        private string GetLrcTimeCode(TimeSpan time)
        {
            return $"[{((int)time.TotalMinutes).ToString().PadLeft(2, '0')}:" +
                $"{time.Seconds.ToString().PadLeft(2, '0')}." +
                $"{(time.Milliseconds / 10).ToString().PadLeft(2, '0')}]";
        }

        private TimeSpan? GetLrcTimeCode(string str)
        {
            if (!CheckLyricSet(str)) return null;

            string time = Regex.Replace(str, @"^\[(?<t>\d+:\d\d((:|\.)\d\d)?)\].+$", "${t}");
            string[] time_seq = time.Split(':');
            

            int min = int.Parse(time_seq[0]);
            int sec;
            int msec = 0;
            if (time_seq.Length == 3)
            {
                sec = int.Parse(time_seq[1]);
                msec = int.Parse(time_seq[2]);
            }
            else if (time_seq[1].Contains('.'))
            {
                string[] c = time_seq[1].Split('.');

                sec = int.Parse(c[0]);
                msec = int.Parse(c[1]);
            }
            else
            { 
                sec = int.Parse(time_seq[1]);
            }
            
            return TimeSpan.FromMilliseconds(((min * 60 + sec) * 100 + msec) * 10);
        }

        private void tbar_pos_Scroll(object sender, EventArgs e)
        {
            if (waveSource == null) return;
            if (!waveSource.CanSeek) return;

            waveSource.SetPosition(TimeSpan.FromMilliseconds(tbar_pos.Value));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (soundOut == null) return;
            soundOut.Volume = (float)trackBar1.Value / 100;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnloadAudioFile();
        }
    }
}
