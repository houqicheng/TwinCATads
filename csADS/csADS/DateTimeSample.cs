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
        TcAdsClient client;


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

                client.AddDeviceNotificationEx("MAIN.time1", AdsTransMode.OnChange, 100, 0, txtTime, typeof(TimeSpan));
                //client.AddDeviceNotificationEx("MAIN.date1", AdsTransMode.OnChange, 100, 0, txtDate, typeof(DateTime));
                client.AdsNotificationEx += AdsNotificationEx;

            }
            catch (Exception err)
            {
                MessageBox.Show("DateTime Form load " + err.Message);
                //throw;
            }
        }        

        private void AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.Value.GetType() == typeof(TimeSpan))
            {
                txtTime.Text = ((TimeSpan)e.Value).ToString();
            }
            else if (e.Value.GetType() == typeof(DateTime))
            {
                txtDate.Text = ((DateTime)e.Value).ToString();
            }
        }
    }
}
