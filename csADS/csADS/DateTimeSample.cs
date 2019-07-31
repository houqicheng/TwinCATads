using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace csADS
{    
    public partial class DateTimeSample : Form
    {
        int htime1;
        int hdate1;
        int hdate2;

        TcAdsClient client;
        AdsBinaryReader reader;
        AdsStream stream;
        AdsBinaryWriter writer;

        public DateTimeSample()
        {
            InitializeComponent();
        }

        private void DateTime_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            client = new TcAdsClient();
            client.Connect(851);
            try
            {
                htime1  = client.CreateVariableHandle("MAIN.time1");
                hdate1 =  client.CreateVariableHandle("MAIN.date1");
                hdate2 = client.CreateVariableHandle("MAIN.date2");
            }
            catch (Exception err)
            {
                MessageBox.Show("DateTime Form load " + err.Message);               
            }
        }        

        private void AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            //
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            stream = new AdsStream(4);
            reader = new AdsBinaryReader(stream);

            try
            {
                client.Read(htime1, stream);

                txtTime.Text = (reader.ReadPlcTIME()).ToString();
                stream.Position = 0;

                client.Read(hdate1, stream);
                txtDate.Text = reader.ReadPlcDATE().ToString();
                stream.Position = 0;

                client.Read(hdate2, stream);
                txtDate2.Text = reader.ReadPlcDATE().ToString();
                stream.Position = 0;


            }
            catch (Exception err)
            {
                MessageBox.Show("BtnRead " + err.Message);                
            }
            

        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                AdsStream stream = new AdsStream(4);
                writer = new AdsBinaryWriter(stream);
                writer.WritePlcType(TimeSpan.Parse(txtTime.Text));

                client.Write(htime1, stream);

                stream.Position = 0;
                writer.WritePlcType(DateTime.Parse(txtDate.Text));
                client.Write(hdate1, stream);

                stream.Position = 0;
                writer.WritePlcType(DateTime.Parse(txtDate2.Text));
                client.Write(hdate2, stream);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnWrite " + err.Message);
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DateTimeSample_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.DeleteVariableHandle(hdate1);
            client.DeleteVariableHandle(htime1);
            client.DeleteVariableHandle(hdate2);

            client.Dispose();
        }
    }
}
