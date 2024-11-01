using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Archive
{
    public partial class RateMovies : Form
    {
        public RateMovies()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MovieArchive;Integrated Security=True");

        void points()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Points",conn);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void RateMovies_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Name,Category,Link from Tbl_Movies", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            points();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            name_txtbox.Text = dataGridView1.Rows[no].Cells[1].Value.ToString();
            category_txtbox.Text = dataGridView1.Rows[no].Cells[2].Value.ToString();
            link_txtbox.Text = dataGridView1.Rows[no].Cells[3].Value.ToString();
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            name_txtbox.Text = "";
            category_txtbox.Text = "";
            link_txtbox.Text = "";
            point_txtbox.Text = "";
        }

        private void rate_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Convert.ToInt16(point_txtbox.Text) <= 10)
            {
                SqlCommand cmd = new SqlCommand("Insert into Tbl_Points (Name,Category,Link,Point) values (@p1,@p2,@p3,@p4)", conn);
                cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                cmd.Parameters.AddWithValue("@p2",category_txtbox.Text);
                cmd.Parameters.AddWithValue("@p3", link_txtbox.Text);
                cmd.Parameters.AddWithValue("@p4", point_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Entry is saved.", "", MessageBoxButtons.OK);
                points();
            }
            if(Convert.ToInt16(point_txtbox.Text)>10 || Convert.ToInt16(point_txtbox.Text) < 0)
            {
                MessageBox.Show("Enter a valid rate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
