namespace Movie_Archive
{
    partial class FullScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullScreen));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.back_bttn = new System.Windows.Forms.Button();
            this.fullscreen_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(800, 450);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // back_bttn
            // 
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bttn.Location = new System.Drawing.Point(763, 0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(37, 25);
            this.back_bttn.TabIndex = 1;
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // fullscreen_bttn
            // 
            this.fullscreen_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullscreen_bttn.BackgroundImage")));
            this.fullscreen_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fullscreen_bttn.Location = new System.Drawing.Point(720, 0);
            this.fullscreen_bttn.Name = "fullscreen_bttn";
            this.fullscreen_bttn.Size = new System.Drawing.Size(37, 25);
            this.fullscreen_bttn.TabIndex = 2;
            this.fullscreen_bttn.UseVisualStyleBackColor = true;
            this.fullscreen_bttn.Click += new System.EventHandler(this.fullscreen_bttn_Click);
            // 
            // FullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fullscreen_bttn);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullScreen";
            this.Load += new System.EventHandler(this.FullScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Button fullscreen_bttn;
    }
}