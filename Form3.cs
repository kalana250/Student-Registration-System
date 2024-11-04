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
    public partial class Form3 : Form
    {
        string con_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mcs\source\repos\DiTEC Project 1\DiTEC Project 1\Properties\Database2.mdf;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            System.Diagnostics.Process.Start("https://learn.esoft.lk/icms/ui/#/home");
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
    
}
