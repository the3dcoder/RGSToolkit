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
    public partial class DeleteComponentVersion : Form
    {
        public DeleteComponentVersion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            cn.Open();
            SqlCommand newcmd = new SqlCommand("Delete from componentversion", cn);
            Clipboard.SetText(newcmd.CommandText);
            SqlDataReader dr;
            MessageBox.Show("Component version has been deleted. Please reopen the software and reinstall database updates.");
            dr = newcmd.ExecuteReader();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
