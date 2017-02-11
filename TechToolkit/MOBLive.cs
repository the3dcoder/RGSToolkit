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
using System.Net.Mail;
using System.Net.Mime;

namespace $safeprojectname$
{
    public partial class MOBLive : Form
    {
        string mobtokenaccount = "select * from WebserviceURL";  //used to pull both the token and webservice url directly
        string mobtoken = "select * from CustomerTokens";        //used to pull tokens from data table
        string mobaccountnumber = "";                            //Stores Mobile Live account number
        string webserviceurl = "";                               //Stores Mobile Live Webservice URL
        string tokenlong = "";                                   //Stores the Token for mobile live

        public MOBLive()
        {
            InitializeComponent();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            string mobserver = "SQL2";                      //Connects to proper database/tables to pull the data
            string mobdatabase = "realgreen";               //Establishes the sql connections to both databases
            string handhelddatabase = "HandheldData";
            SqlConnection cn = new SqlConnection("Data Source=" + mobserver + ";Initial Catalog=" + mobdatabase + ";Integrated Security=True;Connection Timeout=1");
            SqlConnection cn2 = new SqlConnection("Data Source=" + mobserver + ";Initial Catalog=" + handhelddatabase + ";Integrated Security=True;Connection Timeout=1");
            SqlCommand cmdsync = new SqlCommand(mobtoken, cn);
            SqlCommand cmdwebservice = new SqlCommand(mobtokenaccount, cn2);
            cn.Open();
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
 
            while (dr2.Read())  //Searches for webservice url that matches correct token
            {
                if (dr2["Token"].ToString() == tokenlong)
                {
                    webserviceurl = Convert.ToString(dr2["WebserviceURL".ToString()]);
                }
            }
            if (webserviceurl == "")  //Check to see if hosted: sets to default webservice url
            {
                webserviceurl = "http://107.0.253.165/mobilelive/" + mobaccountnumber + "/webservice.asmx ";
            }

            lblTokenDisplay.Text = tokenlong;   //Generates token, webservice, and QR code information
            lblWebserviceDisplay.Text = webserviceurl;
            cn2.Close();
            pbWebserviceQR.ImageLocation = Convert.ToString("http://api.qrserver.com/v1/create-qr-code/?color=000000&bgcolor=FFFFFF&data=" + webserviceurl + "&qzone=1&margin=0&size=175x175&ecc=L");
            pbQRCode.ImageLocation = Convert.ToString("http://api.qrserver.com/v1/create-qr-code/?color=000000&bgcolor=FFFFFF&data=" + tokenlong + "&qzone=1&margin=0&size=175x175&ecc=L");

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var bmp = Bitmap.FromFile(@"C:\Users\ehayes\Desktop\QR Code Sheets\LicenseDevices_cleancopy.bmp");
            var newImage = new Bitmap(bmp, bmp.Width, bmp.Height + 150);
            var newqr = new Bitmap(pbQRCode.Image);
            var newwebserv = new Bitmap(pbWebserviceQR.Image);

            var qr = Graphics.FromImage(newImage);
            var ws = Graphics.FromImage(newImage);
            qr.DrawImageUnscaled(newqr, 65, 495);
            ws.DrawImageUnscaled(newwebserv, 65, 880);

            newImage.Save(@"C:\Users\ehayes\Desktop\QR Code Sheets\newQRsheet.jpg");
            
        }

        private void btnEmailTemplate_Click(object sender, EventArgs e)
        {
            getEmbeddedImage("newQRsheet.jpg");
            sendImg();
        }

        private void sendImg()
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();

            client.Host = "smtp.gmail.com";
            client.Credentials = new System.Net.NetworkCredential("ehayestrainer", "epicbber11");
            
            mail.IsBodyHtml = true;
            mail.AlternateViews.Add(getEmbeddedImage(Program.Database.ToString() + "QRsheet.jpg"));
            mail.From = new MailAddress("ehayes@realgreen.com");
            mail.To.Add("ehayes@realgreen.com");
            mail.Subject = "Mobile Live QR Information";

            client.EnableSsl = true;
            client.Send(mail);

            mail = null;
            client = null;
        }
        private AlternateView getEmbeddedImage(String filePath)
        {
            LinkedResource inline = new LinkedResource(filePath);
            inline.ContentId = Guid.NewGuid().ToString();
            string htmlBody = @"<img src='cid:" + inline.ContentId + @"'/>";
            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            alternateView.LinkedResources.Add(inline);
            return alternateView;
        }
    }
}
