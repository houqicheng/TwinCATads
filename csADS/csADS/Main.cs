using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csADS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtExplain.Text = "1,Read primitive data type.\r\n" +
                 "2,Read int Array from Main\r\n" + "3,Read struct dataType.\r\n";



        }

        private void BtnForm1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sample02 = new Sample02();
            sample02.ShowDialog();
        }
    }
}
