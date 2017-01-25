using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace $safeprojectname$
{
    public partial class LinkedDocs : Form
    {
        public LinkedDocs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldserver = (string)textBox2.Text;
            string newserver = (string)textBox1.Text;
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            cn.Open();
            SqlCommand newcmd = new SqlCommand("update attach set filename = REPLACE(filename, '" + oldserver + ":\\sa\\CUSTDOCS\\', '" + newserver + ":\\sa\\custdocs\\')", cn);
            SqlDataReader dr;
            MessageBox.Show("Linked documents location has been changed.");
            dr = newcmd.ExecuteReader();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
