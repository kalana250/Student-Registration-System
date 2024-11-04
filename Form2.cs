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
    public partial class Form2 : Form
    {
        string con_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mcs\source\repos\DiTEC Project 1\DiTEC Project 1\Properties\Database2.mdf;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
           this.Close();
            Form1 firstForm = new Form1();
            firstForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand mycmd = new SqlCommand("Insert into username values(@sid,@username,@password,@email)", con);
            mycmd.Parameters.AddWithValue("@sid", textBox1.Text);
            mycmd.Parameters.AddWithValue("@username", textBox2.Text);
            mycmd.Parameters.AddWithValue("@password", textBox3.Text);
            mycmd.Parameters.AddWithValue("@email", textBox4.Text);
            
            con.Close();

            MessageBox.Show("Singup Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://learn.esoft.lk/icms/ui/#/home");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://esoft.lk/courses/level-3-diploma-in-information-technology/");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 thirdForm = new Form3();
            thirdForm.Show();
        }
    }
}
