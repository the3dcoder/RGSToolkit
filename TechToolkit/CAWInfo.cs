/*
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
    class CAWInfo
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


    }
}*/
