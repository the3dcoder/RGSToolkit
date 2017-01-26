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
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class MOBLive : Form
    {
        string mobtokenaccount = "select * from WebserviceURL"; //used to pull both the token and webservice url directly
        string mobtoken = "select * from CustomerTokens"; //used to pull tokens from data table
        string mobaccountnumber = "";
        string webserviceurl = "";
        string tokenlong = "";

        //SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");

        public MOBLive()
        {
            InitializeComponent();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            string mobserver = "SQL2"; 
            string mobdatabase = "realgreen";
            string handhelddatabase = "HandheldData";
            SqlConnection cn = new SqlConnection("Data Source=" + mobserver + ";Initial Catalog=" + mobdatabase + ";Integrated Security=True;Connection Timeout=1");
            SqlConnection cn2 = new SqlConnection("Data Source=" + mobserver + ";Initial Catalog=" + handhelddatabase + ";Integrated Security=True;Connection Timeout=1");
            cn.Open();
            SqlCommand cmdsync = new SqlCommand(mobtoken, cn);
            SqlCommand cmdwebservice = new SqlCommand(mobtokenaccount, cn2);
            SqlDataReader dr = cmdsync.ExecuteReader();
               
            try
            {
                Program.Server = mobserver;
                Program.Database = mobdatabase;
                MessageBox.Show("You are now connected to " + mobserver + "\\" + mobdatabase);
            }
            catch (Exception Ex) { MessageBox.Show("Could not connect to SQL Server.\r\n\r\nError Message:\r\n" + Ex.Message); }

            mobaccountnumber = Interaction.InputBox("What is your account number?");

            while (dr.Read())
            {
                if (dr["cust_no"].ToString() == mobaccountnumber.ToString())
                {
                    tokenlong = Convert.ToString(dr["CustomerToken"]);
                }
            }
            dr.Close();
            cn.Close();
            cn2.Open();

            SqlDataReader dr2 = cmdwebservice.ExecuteReader();
 
            while (dr2.Read())
            {
                if (dr2["Token"].ToString() == tokenlong)
                {
                    webserviceurl = Convert.ToString(dr2["WebserviceURL".ToString()]);
                }
            }

            lblTokenDisplay.Text = tokenlong;
            lblWebserviceDisplay.Text = webserviceurl;
            cn2.Close();
            pbWebserviceQR.ImageLocation = Convert.ToString("http://api.qrserver.com/v1/create-qr-code/?color=000000&bgcolor=FFFFFF&data=" + webserviceurl + "&qzone=1&margin=0&size=150x150&ecc=L");
            pbQRCode.ImageLocation = Convert.ToString("http://api.qrserver.com/v1/create-qr-code/?color=000000&bgcolor=FFFFFF&data=" + tokenlong + "&qzone=1&margin=0&size=150x150&ecc=L");

        }
    }
}
