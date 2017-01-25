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
    public partial class Update_Keys : Form
    {
        public Update_Keys()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keytype = (string)comboBox1.Text;
            int keynumber = (int)numericUpDown1.Value;
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            cn.Open();
            SqlCommand newcmd = new SqlCommand("Update Keys set lastkey = " + keynumber + "  where keyname = '" + keytype + "'", cn);
            SqlDataReader dr;
            MessageBox.Show("Last " + keytype + " number was updated to " + keynumber);
            dr = newcmd.ExecuteReader();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
