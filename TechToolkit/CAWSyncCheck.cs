using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace $safeprojectname$
{
    public partial class CAWSyncCheck : Form
    {
        string sql = "select * from cawsyncdowntransaction";
        string email = "h";
        SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");

        public CAWSyncCheck()
        {
            InitializeComponent();
        }

        private void btnSyncDataDisplay_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmdsync = new SqlCommand(sql, cn);
            SqlDataReader dr = cmdsync.ExecuteReader();
            
            while (dr.Read())
            {
                lblSyncTime.Text = Convert.ToString(dr["Completed"]);
                lblSiteID.Text = Convert.ToString(dr["SqlDbId"]);

            }
            cn.Close();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            cn.Open();
            email = Interaction.InputBox("Enter an email address to get a password for:");
            string sqlpassword = "select email, dbo.csswDisplayDetails(password, 854) from csswLoginProfile where email = '" + email + "'";
            SqlCommand cmddecrypt = new SqlCommand(sqlpassword, cn);
            SqlDataReader dr2 = cmddecrypt.ExecuteReader();

            while (dr2.Read())
            {
                lblEmailAddress.Text = email;
                lblPassword.Text = Convert.ToString(dr2.GetString(1));
            }
            cn.Close();

        }

    }

}
