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
        int hBool;
        int hDint1;
        int hByte1;
        int hReal1;
        int hLreal1;




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
                hBool = client.CreateVariableHandle("MAIN.bool1");
                hDint1 = client.CreateVariableHandle("MAIN.dint1");
                hByte1 = client.CreateVariableHandle("MAIN.byte1");
                hReal1 = client.CreateVariableHandle("MAIN.real1");
                hLreal1 = client.CreateVariableHandle("MAIN.lreal1");
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
                txtBool.Text = Convert.ToString(client.ReadAny(hBool, typeof(Boolean)));
                txtDint.Text = Convert.ToString(client.ReadAny(hDint1, typeof(int)));
                txtLreal.Text = Convert.ToString(client.ReadAny(hLreal1, typeof(double)));
                txtReal.Text = Convert.ToString(client.ReadAny(hReal1, typeof(Single)));
                txtByte.Text = Convert.ToString(client.ReadAny(hByte1, typeof(Byte)));

            }
            catch (Exception err)
            {
                MessageBox.Show("btnReadPrimitive " + err.Message);
            }

        }
    }

}
