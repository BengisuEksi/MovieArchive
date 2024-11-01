namespace Movie_Archive
{
    partial class RateMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateMovies));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rate_bttn = new System.Windows.Forms.Button();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.category_txtbox = new System.Windows.Forms.TextBox();
            this.link_txtbox = new System.Windows.Forms.TextBox();
            this.point_txtbox = new System.Windows.Forms.TextBox();
            this.back_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.clear_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(870, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(519, 236);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(363, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Points";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clear_bttn);
            this.groupBox3.Controls.Add(this.point_txtbox);
            this.groupBox3.Controls.Add(this.link_txtbox);
            this.groupBox3.Controls.Add(this.category_txtbox);
            this.groupBox3.Controls.Add(this.name_txtbox);
            this.groupBox3.Controls.Add(this.rate_bttn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 262);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rate Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Point (10): ";
            // 
            // rate_bttn
            // 
            this.rate_bttn.Location = new System.Drawing.Point(179, 201);
            this.rate_bttn.Name = "rate_bttn";
            this.rate_bttn.Size = new System.Drawing.Size(125, 36);
            this.rate_bttn.TabIndex = 4;
            this.rate_bttn.Text = "Rate";
            this.rate_bttn.UseVisualStyleBackColor = true;
            this.rate_bttn.Click += new System.EventHandler(this.rate_bttn_Click);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_txtbox.Location = new System.Drawing.Point(142, 36);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(162, 28);
            this.name_txtbox.TabIndex = 5;
            // 
            // category_txtbox
            // 
            this.category_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category_txtbox.Location = new System.Drawing.Point(142, 77);
            this.category_txtbox.Name = "category_txtbox";
            this.category_txtbox.Size = new System.Drawing.Size(162, 28);
            this.category_txtbox.TabIndex = 6;
            // 
            // link_txtbox
            // 
            this.link_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_txtbox.Location = new System.Drawing.Point(142, 116);
            this.link_txtbox.Name = "link_txtbox";
            this.link_txtbox.Size = new System.Drawing.Size(162, 28);
            this.link_txtbox.TabIndex = 7;
            // 
            // point_txtbox
            // 
            this.point_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.point_txtbox.Location = new System.Drawing.Point(142, 154);
            this.point_txtbox.Name = "point_txtbox";
            this.point_txtbox.Size = new System.Drawing.Size(162, 28);
            this.point_txtbox.TabIndex = 8;
            // 
            // back_bttn
            // 
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bttn.Location = new System.Drawing.Point(840, -1);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 5;
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.Location = new System.Drawing.Point(869, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(33, 30);
            this.exit_bttn.TabIndex = 6;
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // clear_bttn
            // 
            this.clear_bttn.Location = new System.Drawing.Point(42, 201);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(125, 36);
            this.clear_bttn.TabIndex = 9;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // RateMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RateMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RateMovies";
            this.Load += new System.EventHandler(this.RateMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox point_txtbox;
        private System.Windows.Forms.TextBox link_txtbox;
        private System.Windows.Forms.TextBox category_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Button rate_bttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button clear_bttn;
    }
}