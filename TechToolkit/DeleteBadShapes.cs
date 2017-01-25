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
    public partial class DeleteBadShapes : Form
    {
        public DeleteBadShapes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDown1.Value;
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            cn.Open();
            SqlCommand newcmd = new SqlCommand("DELETE FROM [dbo].[CustomerGeographyShape] WHERE cust_no = " + count + "; DELETE FROM[dbo].[CustomerSizeGeographyShape] WHERE cust_no = " + count + "; DELETE FROM[dbo].[MarkCustGeographyShape] WHERE cust_no = " + count + "; DELETE FROM[dbo].[MarkCustSizeGeographyShape] WHERE cust_no = " + count + ";", cn);
            Clipboard.SetText(newcmd.CommandText);
            SqlDataReader dr;
            MessageBox.Show("All measurment shapes were deleted out for Customer # " + count);
            dr = newcmd.ExecuteReader();

        }
    }
}
