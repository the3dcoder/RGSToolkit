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
        string mobtoken = "select * from CustomerTokens";
        string mobaccountnumber = "";
        string tokenlong = "";

        SqlConnection cn = new SqlConnection("Data Source=" + Program.Server + ";Initial Catalog=" + Program.Database + ";Integrated Security=True");

        public MOBLive()
        {
            InitializeComponent();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmdsync = new SqlCommand(mobtoken, cn);
            SqlDataReader dr = cmdsync.ExecuteReader();
            mobaccountnumber = Interaction.InputBox("What is your account number?");

            while (dr.Read())
            {
                if (dr["cust_no"].ToString() == mobaccountnumber.ToString())
                {
                    tokenlong = Convert.ToString(dr["CustomerToken"]);
                }
            }
            lblTokenDisplay.Text = tokenlong;
            cn.Close();
            pbQRCode.ImageLocation = Convert.ToString("http://api.qrserver.com/v1/create-qr-code/?color=000000&bgcolor=FFFFFF&data=" + tokenlong + "&qzone=1&margin=0&size=150x150&ecc=L");

        }
    }
}
