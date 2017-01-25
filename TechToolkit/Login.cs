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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passcode = (string)textBox2.Text;
            string SApasscode = "1";           
            if (passcode == SApasscode)
            {
                MessageBox.Show("Successful Login", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToolkitMain f2 = new ToolkitMain();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
