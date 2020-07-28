namespace LrcMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAudioFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLrcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbar_pos = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_writeText = new System.Windows.Forms.Button();
            this.lbox_lrc = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_setTime = new System.Windows.Forms.Button();
            this.ofd_music = new System.Windows.Forms.OpenFileDialog();
            this.sfd_lrc = new System.Windows.Forms.SaveFileDialog();
            this.timer_setPos = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_lrc_p = new System.Windows.Forms.Label();
            this.lbl_lrc_c = new System.Windows.Forms.Label();
            this.lbl_lrc_n = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openAudioFileToolStripMenuItem,
            this.saveLrcToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openAudioFileToolStripMenuItem
            // 
            this.openAudioFileToolStripMenuItem.Name = "openAudioFileToolStripMenuItem";
            this.openAudioFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAudioFileToolStripMenuItem.Text = "Open Audio File";
            this.openAudioFileToolStripMenuItem.Click += new System.EventHandler(this.openAudioFileToolStripMenuItem_Click);
            // 
            // saveLrcToolStripMenuItem
            // 
            this.saveLrcToolStripMenuItem.Name = "saveLrcToolStripMenuItem";
            this.saveLrcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLrcToolStripMenuItem.Text = "Save lrc";
            this.saveLrcToolStripMenuItem.Click += new System.EventHandler(this.saveLrcToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 404);
            this.splitContainer1.SplitterDistance = 539;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbar_pos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.trackBar1, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(539, 404);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbar_pos
            // 
            this.tbar_pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbar_pos.LargeChange = 0;
            this.tbar_pos.Location = new System.Drawing.Point(73, 3);
            this.tbar_pos.Maximum = 1000;
            this.tbar_pos.Name = "tbar_pos";
            this.tbar_pos.Size = new System.Drawing.Size(463, 24);
            this.tbar_pos.SmallChange = 0;
            this.tbar_pos.TabIndex = 2;
            this.tbar_pos.Scroll += new System.EventHandler(this.tbar_pos_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_writeText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbox_lrc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_writeText
            // 
            this.btn_writeText.BackColor = System.Drawing.Color.Gray;
            this.btn_writeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_writeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_writeText.Location = new System.Drawing.Point(3, 377);
            this.btn_writeText.Name = "btn_writeText";
            this.btn_writeText.Size = new System.Drawing.Size(251, 24);
            this.btn_writeText.TabIndex = 0;
            this.btn_writeText.Text = "Write Text";
            this.btn_writeText.UseVisualStyleBackColor = false;
            this.btn_writeText.Click += new System.EventHandler(this.btn_writeText_Click);
            // 
            // lbox_lrc
            // 
            this.lbox_lrc.BackColor = System.Drawing.Color.Gray;
            this.lbox_lrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_lrc.ForeColor = System.Drawing.Color.White;
            this.lbox_lrc.FormattingEnabled = true;
            this.lbox_lrc.Location = new System.Drawing.Point(3, 3);
            this.lbox_lrc.Name = "lbox_lrc";
            this.lbox_lrc.Size = new System.Drawing.Size(251, 328);
            this.lbox_lrc.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_back, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_setTime, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gray;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(119, 28);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_setTime
            // 
            this.btn_setTime.BackColor = System.Drawing.Color.Gray;
            this.btn_setTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setTime.Location = new System.Drawing.Point(128, 3);
            this.btn_setTime.Name = "btn_setTime";
            this.btn_setTime.Size = new System.Drawing.Size(120, 28);
            this.btn_setTime.TabIndex = 0;
            this.btn_setTime.Text = "Set Time";
            this.btn_setTime.UseVisualStyleBackColor = false;
            this.btn_setTime.Click += new System.EventHandler(this.btn_setTime_Click);
            // 
            // sfd_lrc
            // 
            this.sfd_lrc.DefaultExt = "lrc";
            this.sfd_lrc.Filter = "Lrc File|*.lrc";
            // 
            // timer_setPos
            // 
            this.timer_setPos.Enabled = true;
            this.timer_setPos.Interval = 1;
            this.timer_setPos.Tick += new System.EventHandler(this.timer_setPos_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(73, 377);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(463, 24);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_play);
            this.flowLayoutPanel1.Controls.Add(this.btn_pause);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Gray;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(3, 3);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Gray;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Location = new System.Drawing.Point(84, 3);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_lrc_n, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_lrc_c, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_lrc_p, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(73, 177);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(463, 194);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lbl_lrc_p
            // 
            this.lbl_lrc_p.AutoSize = true;
            this.lbl_lrc_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lrc_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lrc_p.ForeColor = System.Drawing.Color.White;
            this.lbl_lrc_p.Location = new System.Drawing.Point(3, 0);
            this.lbl_lrc_p.Name = "lbl_lrc_p";
            this.lbl_lrc_p.Size = new System.Drawing.Size(457, 40);
            this.lbl_lrc_p.TabIndex = 0;
            this.lbl_lrc_p.Text = "Previous Lyric";
            this.lbl_lrc_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lrc_c
            // 
            this.lbl_lrc_c.AutoSize = true;
            this.lbl_lrc_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lrc_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lrc_c.ForeColor = System.Drawing.Color.White;
            this.lbl_lrc_c.Location = new System.Drawing.Point(3, 40);
            this.lbl_lrc_c.Name = "lbl_lrc_c";
            this.lbl_lrc_c.Size = new System.Drawing.Size(457, 100);
            this.lbl_lrc_c.TabIndex = 1;
            this.lbl_lrc_c.Text = "Current Lyric";
            this.lbl_lrc_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lrc_n
            // 
            this.lbl_lrc_n.AutoSize = true;
            this.lbl_lrc_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lrc_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lrc_n.ForeColor = System.Drawing.Color.White;
            this.lbl_lrc_n.Location = new System.Drawing.Point(3, 140);
            this.lbl_lrc_n.Name = "lbl_lrc_n";
            this.lbl_lrc_n.Size = new System.Drawing.Size(457, 60);
            this.lbl_lrc_n.TabIndex = 2;
            this.lbl_lrc_n.Text = "Next Lyric";
            this.lbl_lrc_n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Position";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 200);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preview";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volume";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lrc Maker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAudioFileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_writeText;
        private System.Windows.Forms.ListBox lbox_lrc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_setTime;
        private System.Windows.Forms.TrackBar tbar_pos;
        private System.Windows.Forms.ToolStripMenuItem saveLrcToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_music;
        private System.Windows.Forms.SaveFileDialog sfd_lrc;
        private System.Windows.Forms.Timer timer_setPos;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_lrc_n;
        private System.Windows.Forms.Label lbl_lrc_c;
        private System.Windows.Forms.Label lbl_lrc_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

