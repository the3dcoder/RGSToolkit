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
    public partial class DeleteJobsSeason : Form
    {
        public DeleteJobsSeason()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = (int)numericUpDown1.Value;
            int year2 = year - 1;
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            cn.Open();
            SqlCommand newcmd = new SqlCommand("Delete program where season = " + year + "; update program set renewed = 0 where season = " + year2, cn);
            SqlDataReader dr;
            MessageBox.Show("All jobs have been deleted in the service year " + year + " and the renewed box has been unchecked on all jobs in the service year " + year2);
            dr = newcmd.ExecuteReader();
        }
    }
}
