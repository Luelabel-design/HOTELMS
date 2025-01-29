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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace HOTELMS
{
    public partial class Guest : Form
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
        public Guest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            MessageBox.Show("Room Successfully Booked");
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomtype.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            clientphone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tbl where Roomtype = '" + roomtype.SelectedText + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        DateTime today;
        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDBDataSet.Room_tbl' table. You can move, or remove it, as needed.
            //this.room_tblTableAdapter.Fill(this.hMSDBDataSet.Room_tbl);
            today = checkin.Value;
            populate();
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
    }
}
