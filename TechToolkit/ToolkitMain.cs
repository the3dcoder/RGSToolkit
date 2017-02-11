using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class ToolkitMain : Form
    {
        
        public ToolkitMain()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Keys Form2 = new Update_Keys();

            Form2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            DeleteBadShapes Form4 = new DeleteBadShapes();

            Form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateConnection Form3 = new CreateConnection();

            Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteJobsSeason Form5 = new DeleteJobsSeason ();

            Form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteComponentVersion Form6 = new DeleteComponentVersion();

            Form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LinkedDocs Form7 = new LinkedDocs();

            Form7.Show();
        }

        private void btnCAWSyncCheck_Click(object sender, EventArgs e)
        {
            CAWSyncCheck Form8 = new CAWSyncCheck();

            Form8.Show();
        }

        private void btnMobileLive_Click(object sender, EventArgs e)
        {
            MOBLive Form9 = new MOBLive();

            Form9.Show();
        }

        private void clearDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Server = "";
            Program.Database = "";
        }
    }
}
