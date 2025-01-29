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
    public partial class Staffinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\hms\real\HMSDB.mdf;Integrated Security=True;Connect Timeout=30;");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        public Staffinfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void edittb_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Staff_tbl set Staffname ='" + staffname.Text + "', staffphone ='" + staffphone.Text + "', Gender = '" + Gender.SelectedItem.ToString() + "' where staffpassword = " + staffpassword.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff data Edited");
            Con.Close();
            populate();
        }
        

        private void deletetb_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where StaffId =" + staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Deleted");
            Con.Close();
            populate();
        }

        private void addtb_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values('" + staffidtbl.Text + "','" + staffname.Text + "','" + staffphone.Text+ "', '"+Gender.SelectedItem.ToString()+ "','" + staffpassword + "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Added");
            Con.Close();
            populate();
        }

        private void clientage_TextChanged(object sender, EventArgs e)
        {

        }
        private void Staffinfo_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
            timer1.ToString();
            populate();
            // TODO: This line of code loads data into the 'hMSDBDataSetCLIENT.Client_tbl' table. You can move, or remove it, as needed.
        }
        private void clientphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientidtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffidtbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            staffname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            staffphone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            staffpassword.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl where staffname = '" + textBox5.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Staffinfo_Load_1(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Today.ToString();
            populate();
        }
    }
}
