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
    public partial class CreateConnection : Form
    {

        public CreateConnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string server = (string)textBox1.Text;
            string database = (string)textBox2.Text;
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=True;Connection Timeout=1");
                cn.Open();
                {               
                    Program.Server = server;
                    Program.Database = database;
                    MessageBox.Show("You are now connected to " + server + "\\" + database);
                }
                cn.Dispose();    
            }
            catch (Exception Ex) { MessageBox.Show("Could not connect to SQL Server.\r\n\r\nError Message:\r\n" + Ex.Message); }



        }
    }
}
