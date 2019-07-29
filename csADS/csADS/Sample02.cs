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
using System.IO;


namespace csADS
{
    public partial class Sample02 : Form
    {
        TcAdsClient client;
        int hPLCVar;
        BinaryWriter writer;
        AdsStream stream;
        public Sample02()
        {
            InitializeComponent();
        }

        private void Sample02_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcAdsClient();
                client.Connect(851);
                
                hPLCVar = client.CreateVariableHandle("MAIN.PLCVar");                
            }
            catch (Exception err)
            {
                MessageBox.Show("Sample02_Load " + err.Message);                
            } 
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            stream = new AdsStream(32);
            writer = new BinaryWriter(stream);
            stream.Position = 0;
            try
            {
                writer.Write(short.Parse(txtINT.Text));
                stream.Position = 4;
                writer.Write(int.Parse(txtDINT.Text));
                stream.Position = 8;
                writer.Write(byte.Parse(txtByte.Text));
                stream.Position = 16;
                writer.Write(double.Parse(txtLreal.Text));
                stream.Position = 24;
                writer.Write(float.Parse(txtReal.Text));  
                client.Write(hPLCVar, stream);                
            }
            catch (Exception err)
            {
                MessageBox.Show("btnWrite " + err.Message);
            }
            
        }

        private void Sample02_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.DeleteVariableHandle(hPLCVar);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);                
            }
            client.Dispose();
        }
    }
}
