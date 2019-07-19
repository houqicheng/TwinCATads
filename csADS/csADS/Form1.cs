using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace csADS
{
    public partial class Form1 : Form
    {
        TcAdsClient client;
        int hint;
        int hbool;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new TcAdsClient();
            try
            {
                client.Connect(851);
                hint = client.CreateVariableHandle("MAIN.int1");
            }
            catch (Exception err)
            {
                MessageBox.Show("Form load " + err.Message);
            }  
        }

        private void btnReadPrimitive_Click(object sender, EventArgs e)
        {
            try
            {
                txtINT.Text = Convert.ToString(client.ReadAny(hint, typeof(short)));

            }
            catch (Exception err)
            {
                MessageBox.Show("btnReadPrimitive " + err.Message);
            }

        }
    }
}
