namespace Movie_Archive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save_bttn = new System.Windows.Forms.Button();
            this.link_txtbox = new System.Windows.Forms.TextBox();
            this.category_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aboutus_bttn = new System.Windows.Forms.Button();
            this.changecolor_bttn = new System.Windows.Forms.Button();
            this.fullscreen_bttn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.ratemovie_bttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_bttn);
            this.groupBox1.Controls.Add(this.save_bttn);
            this.groupBox1.Controls.Add(this.link_txtbox);
            this.groupBox1.Controls.Add(this.category_txtbox);
            this.groupBox1.Controls.Add(this.name_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Movie";
            // 
            // save_bttn
            // 
            this.save_bttn.Location = new System.Drawing.Point(20, 145);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(125, 34);
            this.save_bttn.TabIndex = 6;
            this.save_bttn.Text = "Save";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // link_txtbox
            // 
            this.link_txtbox.Location = new System.Drawing.Point(101, 103);
            this.link_txtbox.Name = "link_txtbox";
            this.link_txtbox.Size = new System.Drawing.Size(173, 27);
            this.link_txtbox.TabIndex = 5;
            // 
            // category_txtbox
            // 
            this.category_txtbox.Location = new System.Drawing.Point(101, 64);
            this.category_txtbox.Name = "category_txtbox";
            this.category_txtbox.Size = new System.Drawing.Size(173, 27);
            this.category_txtbox.TabIndex = 4;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(101, 26);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(173, 27);
            this.name_txtbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Link: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ratemovie_bttn);
            this.groupBox2.Controls.Add(this.aboutus_bttn);
            this.groupBox2.Controls.Add(this.changecolor_bttn);
            this.groupBox2.Controls.Add(this.fullscreen_bttn);
            this.groupBox2.Location = new System.Drawing.Point(309, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // aboutus_bttn
            // 
            this.aboutus_bttn.Location = new System.Drawing.Point(13, 150);
            this.aboutus_bttn.Name = "aboutus_bttn";
            this.aboutus_bttn.Size = new System.Drawing.Size(268, 37);
            this.aboutus_bttn.TabIndex = 9;
            this.aboutus_bttn.Text = "About Us";
            this.aboutus_bttn.UseVisualStyleBackColor = true;
            this.aboutus_bttn.Click += new System.EventHandler(this.aboutus_bttn_Click);
            // 
            // changecolor_bttn
            // 
            this.changecolor_bttn.Location = new System.Drawing.Point(13, 109);
            this.changecolor_bttn.Name = "changecolor_bttn";
            this.changecolor_bttn.Size = new System.Drawing.Size(268, 37);
            this.changecolor_bttn.TabIndex = 8;
            this.changecolor_bttn.Text = "Change Colour";
            this.changecolor_bttn.UseVisualStyleBackColor = true;
            this.changecolor_bttn.Click += new System.EventHandler(this.changecolor_bttn_Click);
            // 
            // fullscreen_bttn
            // 
            this.fullscreen_bttn.Location = new System.Drawing.Point(13, 26);
            this.fullscreen_bttn.Name = "fullscreen_bttn";
            this.fullscreen_bttn.Size = new System.Drawing.Size(268, 37);
            this.fullscreen_bttn.TabIndex = 7;
            this.fullscreen_bttn.Text = "Full Screen";
            this.fullscreen_bttn.UseVisualStyleBackColor = true;
            this.fullscreen_bttn.Click += new System.EventHandler(this.fullscreen_bttn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chromiumWebBrowser1);
            this.groupBox4.Location = new System.Drawing.Point(606, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 412);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Screen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 80);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(395, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie Archive Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clear_bttn
            // 
            this.clear_bttn.Location = new System.Drawing.Point(151, 145);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(123, 34);
            this.clear_bttn.TabIndex = 7;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(3, 23);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(480, 386);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // ratemovie_bttn
            // 
            this.ratemovie_bttn.Location = new System.Drawing.Point(13, 67);
            this.ratemovie_bttn.Name = "ratemovie_bttn";
            this.ratemovie_bttn.Size = new System.Drawing.Size(268, 37);
            this.ratemovie_bttn.TabIndex = 10;
            this.ratemovie_bttn.Text = "Rate Movies";
            this.ratemovie_bttn.UseVisualStyleBackColor = true;
            this.ratemovie_bttn.Click += new System.EventHandler(this.ratemovie_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox link_txtbox;
        private System.Windows.Forms.TextBox category_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aboutus_bttn;
        private System.Windows.Forms.Button changecolor_bttn;
        private System.Windows.Forms.Button fullscreen_bttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_bttn;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button ratemovie_bttn;
    }
}

