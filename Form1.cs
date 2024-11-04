using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DiTEC_Project_1
{
    public partial class Form1 : Form
    {
        string con_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mcs\source\repos\DiTEC Project 1\DiTEC Project 1\Properties\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand mycmd = new SqlCommand("Insert into student values(@sid,@name,@age,@address,@dob,@gender)", con);
            mycmd.Parameters.AddWithValue("@sid", textBox1.Text);
            mycmd.Parameters.AddWithValue("@name", textBox2.Text);
            mycmd.Parameters.AddWithValue("@age", textBox3.Text);
            mycmd.Parameters.AddWithValue("@address", textBox4.Text);
            mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            mycmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            
            con.Close();

            MessageBox.Show("Inserted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand mycmd = new SqlCommand("Update student set name=@name,age=@age,address=@address,dob=@dob,gender=@gender where sid=@sid", con);
            mycmd.Parameters.AddWithValue("@sid", textBox1.Text);
            mycmd.Parameters.AddWithValue("@name", textBox2.Text);
            mycmd.Parameters.AddWithValue("@age", textBox3.Text);
            mycmd.Parameters.AddWithValue("@address", textBox4.Text);
            mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            mycmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            
            con.Close();

            MessageBox.Show("Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand mycmd = new SqlCommand("Delete from student where sid=@sid", con);
            mycmd.Parameters.AddWithValue("@sid", textBox1.Text);
            mycmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand mycmd = new SqlCommand("Select*from student", con);
            SqlDataAdapter ad = new SqlDataAdapter(mycmd);

            DataTable data = new DataTable();
            ad.Fill(data);


            dataGridView1.DataSource = data;

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) ;
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
