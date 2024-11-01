using System;
using System.Windows.Forms;
namespace Movie_Archive
{
    public partial class FullScreen : Form
    {
        public FullScreen()
        {
            InitializeComponent();
        }
        public string link;
        private void FullScreen_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(link);
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Close();
            fr.Show();
        }
        int click_num = 0;
        private void fullscreen_bttn_Click(object sender, EventArgs e)
        {
            click_num++;
            if(click_num % 2 == 1)
            {
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                back_bttn.Left = this.ClientSize.Width - back_bttn.Width;
                back_bttn.Top = 0;
                fullscreen_bttn.Left = back_bttn.Left - fullscreen_bttn.Width;
                fullscreen_bttn.Top = 0;
            }
            if(click_num % 2 == 0)
            {
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
                back_bttn.Left = this.ClientSize.Width - back_bttn.Width;
                back_bttn.Top = 0;
                fullscreen_bttn.Left = back_bttn.Left - fullscreen_bttn.Width;
                fullscreen_bttn.Top = 0;
            }
        }
    }
}
