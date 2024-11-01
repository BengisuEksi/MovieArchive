using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CefSharp.WinForms;

namespace Movie_Archive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MovieArchive;Integrated Security=True");
        
        void movies()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Name,Link from Tbl_Movies",conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            movies();
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Movies (Name,Category,Link) values (@p1,@p2,@p3)", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", category_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", link_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New entry is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            movies();
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            name_txtbox.Text = "";
            category_txtbox.Text = "";
            link_txtbox.Text = "";
        }
        ChromiumWebBrowser chromiumWebBrowser;
        string link = "";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FullScreen fr = new FullScreen();
            int no = dataGridView1.SelectedCells[0].RowIndex;
            link = dataGridView1.Rows[no].Cells[2].Value.ToString();
            chromiumWebBrowser1.Load(link);
        }

        private void aboutus_bttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was created by Bengisu Ekşi on the 1st of November,2024.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changecolor_bttn_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.DarkGreen,Color.DarkGray,Color.Crimson,Color.Coral,Color.Yellow,Color.Violet,Color.RosyBrown,Color.AliceBlue };
            Random rndm = new Random();
            int num = rndm.Next(0,colors.Length);
            this.BackColor = colors[num];
        }

        private void fullscreen_bttn_Click(object sender, EventArgs e)
        {
            FullScreen fr = new FullScreen();
            fr.link = link;
            this.Hide();
            fr.Show();
        }

        private void ratemovie_bttn_Click(object sender, EventArgs e)
        {
            RateMovies fr = new RateMovies();
            this.Hide();
            fr.Show();
        }
    }
}
