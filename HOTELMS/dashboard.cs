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
    public partial class dashboard : Form
    {

SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\hms\real\HMSDB.mdf;Integrated Security=True;Connect Timeout=30;");
        public void populate()
        {        
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
        DateTime today;

        private void dashboard_Load(object sender, EventArgs e)
        {
            today = checkin.Value;
           populate();
            datelbl.Text = DateTime.Today.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            clientphone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            RoomId.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl where staffname = '" + textBox5.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void checkin_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(checkin.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong Date For Reservation");
        }

        private void checkout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(checkout.Value, checkin.Value);
            if (res < 0)
                MessageBox.Show("Wrong  Date For Checking Out");
        }
        public void updateroomstate()
        {
            Con.Open();
            string newstate = "busy";
            string myquery = "UPDATE Room_tbl set Roomavailability ='" + newstate + "' where RoomId =" + RoomId.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();  
            Con.Close();

        }
        private void addtb_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values('" + reservidtbl.Text + "','" + clientphone.Text + "','" + RoomId.Text + "', '" + checkin.Value + "','" + checkout.Value + "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully reserved");
            Con.Close();
            populate();
        }

        private void deletetb_Click(object sender, EventArgs e)
        {
            if (reservidtbl.Text == "")
            {
                MessageBox.Show("Enter the reservation to be deleted");
            }
            else
            {


                Con.Open();
                string query = "delete from Reservation_tbl where ResId =" + reservidtbl.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Deleted");
                Con.Close();
                populate();
            }
        }
    }
}
