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
    public partial class Clientinfo : Form
    {
        SqlConnection Con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\hms\real\HMSDB.mdf;Integrated Security=True;Connect Timeout=30;");
       public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder  = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];  
            Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
            timer1.ToString();
            populate();
            // TODO: This line of code loads data into the 'hMSDBDataSetCLIENT.Client_tbl' table. You can move, or remove it, as needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values('"+ clientidtbl.Text+ "','"+ clientage.Text+"','"+clientphone.Text+"','"+clientemail.Text+"' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            clientage.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            clientphone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            clientemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void deletetb_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where ClientId =" + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);    
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Deleted");
            Con.Close() ;
            populate();

        }

        private void edittb_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set clientage ='" + clientage.Text + "', clientphone ='" + clientphone.Text + "', clientemail = '" + clientemail + "' where ClientId = " + clientidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Client_tbl where clientage = '"+textBox5.Text+"'";
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