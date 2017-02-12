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
        
        SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True;Connection Timeout=1");

        public CreateConnection()
        {
            InitializeComponent();
        }

        private void CBDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string server = CBServer.SelectedItem.ToString();
            int count;

            Program.Server = server;
            textBox1.Text = server;
            textBox1.Enabled = false;

            CBDatabase.Items.Clear();

            List<String> listofdatabases = new List<String>();
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Integrated Security=True;Connection Timeout=1");

            cn.Open();

            using (SqlCommand generatedatabases = new SqlCommand("select * from sys.databases", cn))
            {
                using (IDataReader dr = generatedatabases.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listofdatabases.Add(dr["name"].ToString());
                    }
                }
            }

            count = listofdatabases.Count - 4;
            listofdatabases.RemoveRange(0, 3); //Makes sure the database info is in the correct order (there are some 
                                                //junk databases to be skipped over in initi
            listofdatabases.Reverse();

            while (--count > 0)
            {
                CBDatabase.Items.Add(listofdatabases[count]); //creates the list of databases to display
            }

            CBDatabase.Sorted = true;
        }

        private void CBDatabase_SelectedIndexChanged_1(object sender, EventArgs e) //Keeps the database cb and textbox linked
        {
            textBox2.Text = CBDatabase.SelectedItem.ToString();
            textBox2.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e) //Clears out and allows for additional connectdions
        {
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";

            CBServer.Text = "      Server:";
            CBDatabase.Text = "                            Database:";

            CBServer.Update();
            CBDatabase.Update();
        }

        private void btnConnect_Click(object sender, EventArgs e)
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
            }
            catch (Exception Ex) { MessageBox.Show("Could not connect to SQL Server.\r\n\r\nError Message:\r\n" + Ex.Message); }

            CreateConnection.ActiveForm.Hide(); 
        }

        private void clearDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Server = "";
            Program.Database = "";

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";

            CBServer.Text = "      Server:";
            CBDatabase.Text = "                            Database:";

            CBServer.Update();
            CBDatabase.Update();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
            catch (Exception Ex) { MessageBox.Show("Could not connect to SQL Server.\r\n\r\nError Message:\r\n" + Ex.Message); }

            CreateConnection.ActiveForm.Hide(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
