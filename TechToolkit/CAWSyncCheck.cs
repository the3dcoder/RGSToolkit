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
using System.Globalization;

namespace $safeprojectname$
{
    public partial class CAWSyncCheck : Form
    {
        string email = "h";
        List<String> synctimes = new List<string>();
        List<String> paymentsrecieved = new List<String>();
        List<String> listaccountnumbers = new List<String>();
        List<Decimal> paymentsrecievedamount = new List<Decimal>();
        SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");

        public CAWSyncCheck()
        {
            InitializeComponent();
            lblCurrentDatabase.Text = Program.Database;
            lblCurrentServer.Text = Program.Server;
        }

        private void btnSyncDataDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");
            lblCurrentDatabase.Text = Program.Database;
            lblCurrentServer.Text = Program.Server;

            switch (Convert.ToString(Program.Server))
            {
                case ("SQL4"):
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
                        break;
                    }
                case ("SQL6"):   //using as an example to build out future sql queries, building up on 2/8
                    {
                        
                        string SQLDBID = Interaction.InputBox("You're connecting to Server: SQL6 and Database: " + Program.Database + ". Please enter the SQLDBID for your Query");
                        cn.Open();
                        string franchisepaymentquery = "select * from csswPaymentLog where sqldbid = '" + SQLDBID + "'";
                        string cawPaymentErrorLog = "select * from cawPaymentErrorLog where sqldbid = '" + SQLDBID + "'";
                        string autopayenrollment = "select * from csswautopayenrollmentslog where sqldbid = '" + SQLDBID + "'";
                        string marketID = "select * from marketid where sqldbid = '" + SQLDBID + "'";
                        string autopayment = "select * from csswpaymentlog where sqldbid = '" + SQLDBID + "'";
                        string payment = "select * from csswpaymentlog where sqldbid = '" + SQLDBID + "'";
                        string sql = "select * from cawsyncdowntransaction where sqldbid = '" + SQLDBID + "'";
                        SqlCommand cmdsync = new SqlCommand(sql, cn);
                        SqlCommand sqlpayment = new SqlCommand(payment, cn);
                        SqlCommand sqlautopayment = new SqlCommand(autopayment, cn);
                        SqlCommand sqlmarketid = new SqlCommand(marketID, cn);
                        SqlCommand sqlautopayenrollment = new SqlCommand(autopayenrollment, cn);
                        SqlCommand sqlcawpaymenterror = new SqlCommand(cawPaymentErrorLog, cn);
                        SqlCommand sqlfranchisepayment = new SqlCommand(franchisepaymentquery, cn);
                        SqlDataReader dr = cmdsync.ExecuteReader();
                        List<String> synctimes = new List<string>();
                        List<String> paymentsrecieved = new List<String>();
                        List<String> autopayenrollist = new List<String>();
                        List<String> autopayloglist = new List<String>();
                        List<String> cawpaymenterrorlist = new List<String>();
                        int syncsiteid;

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

                        SqlDataReader dr3 = sqlautopayment.ExecuteReader();
                        {

                        }

                        dr3.Close();

                        SqlDataReader dr4 = sqlmarketid.ExecuteReader();
                        {

                        }

                        dr4.Close();

                        SqlDataReader dr5 = sqlautopayenrollment.ExecuteReader();
                        {

                        }

                        dr5.Close();

                        SqlDataReader dr6 = sqlcawpaymenterror.ExecuteReader();
                        {

                        }

                        dr6.Close();

                        SqlDataReader dr7 = sqlfranchisepayment.ExecuteReader();
                        {

                        }

                        dr7.Close();
                        cn.Close();
                        break;
                    }
                case ("SQL2"):
                    {
                    Program.Database = "";
                    Program.Server = "";
                    var error = MessageBox.Show("Cannot perform action on Server: SQL2, please connect to a valid server", "Server Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    lblCurrentDatabase.Text = Program.Database;
                    lblCurrentServer.Text = Program.Server;
                    break;
                    }
                case "":
                    {
                    Program.Database = "";
                    Program.Server = "";
                    var error = MessageBox.Show("No server to connect to, please connect to a valid server", "Server Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    lblCurrentDatabase.Text = Program.Database;
                    lblCurrentServer.Text = Program.Server;
                    break;
                    }
                default:
                    {
                        cn.Open();
                        string payment = "select * from csswpaymentlog";
                        string sql = "select * from cawsyncdowntransaction";
                        SqlCommand cmdsync = new SqlCommand(sql, cn);
                        SqlCommand sqlpayment = new SqlCommand(payment, cn);
                        SqlDataReader dr = cmdsync.ExecuteReader();

                        int count = 0;
                        cmdsync.CommandTimeout = 0;
                        sqlpayment.CommandTimeout = 0;
                        while (dr.Read())
                        {
                            synctimes.Add(Convert.ToString(dr["Completed"]));
               
                            lblSiteID.Text = Convert.ToString(dr["SqlDbId"]);
                        }

                        dr.Close();
                        count = 0;
                        SqlDataReader dr2 = sqlpayment.ExecuteReader();

                        while (dr2.Read())
                        {
                            paymentsrecieved.Add(Convert.ToString(dr2["paydate"]));
                            paymentsrecievedamount.Add(Convert.ToDecimal(dr2["amount"]));
                            listaccountnumbers.Add(Convert.ToString(dr2["cust_no"]));

                        }
                        paymentsrecievedamount.Reverse();
                        paymentsrecieved.Reverse();
                        synctimes.Reverse();
                        listaccountnumbers.Reverse();
                        dr2.Close();
                        cn.Close();
                        
                        while (count < 10)
                        {
                            //Counter loop to gather and display the most recent 10 results (will be gathering this into a class in the future)
                            LBSyncTimes.Items.Add(synctimes[count]);
                            LBPayments.Items.Add(paymentsrecieved[count]);
                            LBPaymentAmounts.Items.Add(paymentsrecievedamount[count].ToString("C2"));
                            LBAccountNumber.Items.Add(listaccountnumbers[count]);
                            count++;
                        }
                        break;
                    }
            }
            //Load the most recent display lables
            lblLastPayment.Text = LBPayments.Items[2].ToString();
            lblPaymentAmount.Text = LBPaymentAmounts.Items[2].ToString();
            lblSyncTime.Text = LBSyncTimes.Items[2].ToString();
            
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

        private void CAWSyncCheck_Load(object sender, EventArgs e)
        {

        }


        //Simple checks to keep the selected indexes together. (To add: right and left click abilities, possibly a lookup in the cust no list)
        private void LBPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter;
            counter = LBPayments.SelectedIndex;
            LBPaymentAmounts.SelectedIndex = counter;
            LBSyncTimes.SelectedIndex = counter;
            LBAccountNumber.SelectedIndex = counter;
        }

        private void LBPaymentAmounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter;
            counter = LBPaymentAmounts.SelectedIndex;
            LBPayments.SelectedIndex = counter;
            LBSyncTimes.SelectedIndex = counter;
            LBAccountNumber.SelectedIndex = counter;
        }

        private void LBAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter;
            counter = LBAccountNumber.SelectedIndex;
            LBPayments.SelectedIndex = counter;
            LBSyncTimes.SelectedIndex = counter;
            LBPaymentAmounts.SelectedIndex = counter;
        }

        private void LBSyncTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter;
            counter = LBSyncTimes.SelectedIndex;
            LBPayments.SelectedIndex = counter;
            LBAccountNumber.SelectedIndex = counter;
            LBPaymentAmounts.SelectedIndex = counter;
        }

        private void clearDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count =11;

            Program.Server = "";
            Program.Database = "";

            lblEmailAddress.Text = "";
            lblEmailAddress.Text = "";

            lblPaymentAmount.Text = "";
            lblSiteID.Text = "";
            lblLastPayment.Text = "";
            lblSyncTime.Text = "";

            synctimes.Clear();
            paymentsrecievedamount.Clear();
            listaccountnumbers.Clear();
            paymentsrecieved.Clear();

            while (count > 1)
            {
                LBSyncTimes.Items.RemoveAt(count);
                LBPayments.Items.RemoveAt(count);
                LBAccountNumber.Items.RemoveAt(count);
                LBPaymentAmounts.Items.RemoveAt(count);
                count--;
            }
            /*
            SqlCommand cmdsync = new SqlCommand(sql, cn);
            SqlCommand sqlpayment = new SqlCommand(payment, cn);
            SqlDataReader dr = cmdsync.ExecuteReader();
            List<String> synctimes = new List<string>();
            List<String> paymentsrecieved = new List<String>();
            List<String> listaccountnumbers = new List<String>();
            List<Decimal> paymentsrecievedamount = new List<Decimal>();*/

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConnection Form3 = new CreateConnection();

            Form3.Show();
        }
    }
}
