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
        string email = "h";
        SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");

        public CAWSyncCheck()
        {
            InitializeComponent();
        }

        private void btnSyncDataDisplay_Click(object sender, EventArgs e)
        {
            cn.Open();
            string payment = "select * from csswpaymentlog";
            string sql = "select * from cawsyncdowntransaction";
            SqlCommand cmdsync = new SqlCommand(sql, cn);
            SqlCommand sqlpayment = new SqlCommand(payment, cn);
            SqlDataReader dr = cmdsync.ExecuteReader(); 

            while (dr.Read())
            {
                lblSyncTime.Text = Convert.ToString(dr["Completed"]);
                lblSiteID.Text = Convert.ToString(dr["SqlDbId"]);
            }

            dr.Close();

            SqlDataReader dr2 = sqlpayment.ExecuteReader();
            
            while (dr2.Read())
            {
                lblLastPayment.Text = Convert.ToString(dr2["paydate"]);
                lblPaymentAmount.Text = Convert.ToString(Convert.ToDecimal(dr2["amount"]));
            }
            dr2.Close();
            cn.Close();
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            cn.Open();
            email = Interaction.InputBox("Enter an email address to get a password for:");
            string sqlpassword = "select email, dbo.csswDisplayDetails(password, 854) from csswLoginProfile where email = '" + email + "'";
            SqlCommand cmddecrypt = new SqlCommand(sqlpassword, cn);
            SqlDataReader dr3 = cmddecrypt.ExecuteReader();

            while (dr3.Read())
            {
                lblEmailAddress.Text = email;
                lblPassword.Text = Convert.ToString(dr3.GetString(1));
            }
            dr3.Close();
            cn.Close();
        }
    }
}
