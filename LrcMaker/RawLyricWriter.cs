using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrcMaker
{
    public partial class RawLyricWriter : Form
    {

        public string Base;

        public RawLyricWriter(string b)
        {
            InitializeComponent();

            Base = b;
            richTextBox1.Text = Base;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Base = richTextBox1.Text.Replace("\r\n", "\n").Replace('\r','\n');
            Close();
        }
    }
}
