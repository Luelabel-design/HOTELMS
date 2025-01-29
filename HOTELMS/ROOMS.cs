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
using System.Data.SqlClient;

namespace HOTELMS
{
    public partial class ROOMS : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\hms\real\HMSDB.mdf;Integrated Security=True;Connect Timeout=30;");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }


        public ROOMS()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void addtb_Click(object sender, EventArgs e)
        {
            string isfree;
            if (free.Checked == true)
                isfree = "free";
            else
                isfree = "busy";

            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Room_tbl (RoomID, RoomPhone, Roomavailability, Roomtype) VALUES (@RoomID, @RoomPhone, @Roomavailability, @Roomtype)", Con);
            cmd.Parameters.AddWithValue("@RoomID", roomidtbl.Text);
            cmd.Parameters.AddWithValue("@RoomPhone", roomphone.Text);
            cmd.Parameters.AddWithValue("@Roomtype", roomtype.Text);
            cmd.Parameters.AddWithValue("@Roomavailability", isfree);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Added");
            Con.Close();

            populate();
        }

        private void deletetb_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tbl where RoomId =" + roomidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Deleted");
            Con.Close();
            populate();
        }

        private void edittb_Click(object sender, EventArgs e)
        {
            string isfree;
            if (free.Checked == true)
                isfree = "free";
            else
                isfree = "busy";
            Con.Open();
            string myquery = "UPDATE Room_tbl set Roomphone ='" + roomphone.Text + "', Roomavailability ='" + isfree + "', ' where RoomId = " + roomidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room data Edited");

            Con.Close();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            roomphone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            roomtype.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void ROOMS_Load(object sender, EventArgs e)
        {
            populate();
            datelbl.Text = DateTime.Today.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where RoomId = '" + textBox5.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
