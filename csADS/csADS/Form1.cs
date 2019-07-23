﻿using System;
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
    public partial class Form1 : Form
    {
        TcAdsClient client;
        int hint;
        int hBool;
        int hDint1;
        int hByte1;
        int hReal1;
        int hLreal1;
        int hstr1;
        int hstr2;
        //-------read int array
        int hintArray;
        AdsBinaryReader Reader;
        AdsStream stream;
        //------------
        int hComplexStruct;

        int hdintArray1;

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
                hstr1 = client.CreateVariableHandle("MAIN.str1");
                hstr2 = client.CreateVariableHandle("MAIN.str2");
                hComplexStruct = client.CreateVariableHandle("MAIN.complexStruct");

                //----------Read int array--------
                stream = new AdsStream(10 * 2);

                Reader = new AdsBinaryReader(stream);

                hintArray = client.CreateVariableHandle("MAIN.intArray");
                //-----------------------------------
                hdintArray1 = client.CreateVariableHandle("MAIN.DintArray1");



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
                txtByte.Text = Convert.ToString(client.ReadAny(hByte1, typeof(Byte)));
                txtByte.Text = Convert.ToString(client.ReadAny(hByte1, typeof(Byte)));
                txtStr1.Text = Convert.ToString(client.ReadAny(hstr1, typeof(string), new int[] { 50 }));
                txtStr2.Text = Convert.ToString(client.ReadAny(hstr2, typeof(string), new int[] { 50 }));



            }
            catch (Exception err)
            {
                MessageBox.Show("btnReadPrimitive " + err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            client.Read(hintArray, stream);

            for (int i = 0; i < 10; i++)
            {
                lstArray.Items.Add(Reader.ReadInt16());
            }

            lstArray2.Items.Clear();

            // client.ReadAny(hdintArray1, typeof(int), new int[] { 40 });
            //??  how to read DINT array from plc by ReadAny method  ??

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();

        }

        private void BtnReadStruct_Click(object sender, EventArgs e)
        {
            ComplexStruct cs;
            cs = (ComplexStruct)client.ReadAny(hComplexStruct, typeof(ComplexStruct));

            FillComplex(cs);

        }

        private void FillComplex(ComplexStruct cs)
        {
            string temp = "";
            txtIntVal.Text = cs.intVal.ToString();
            temp = cs.dintArray[0].ToString() + "," + cs.dintArray[1].ToString() + ",";
            temp = temp + cs.dintArray[2].ToString() + "," + cs.dintArray[3].ToString() + "," + cs.dintArray[4].ToString();
            txtDintVal.Text = temp;
            txtBoolVal.Text = cs.boolVal.ToString();
            txtByteVal.Text = cs.byteVal.ToString();
            txtStr1Val.Text = cs.stringVal.ToString();
            txtLrealVal.Text = cs.lrealVal.ToString();

            txtSimpleDint.Text = cs.simple.dintVal.ToString();
            txtSimpleLreal.Text = cs.simple.lrealVal.ToString();


        }
        private ComplexStruct GetStruct()
        {
            ComplexStruct cs = new ComplexStruct();
            cs.intVal = short.Parse(txtIntVal.Text);
            string[] str = txtDintVal.Text.Split(new char[] { ',' });
            for (int i = 0; i < str.Length; i++)
            {
                cs.dintArray[i] = int.Parse(str[i]);
            }
            cs.boolVal = Boolean.Parse(txtBoolVal.Text);

            
            cs.byteVal = byte.Parse(txtByteVal.Text);
            cs.lrealVal = double.Parse(txtLrealVal.Text);
            
            cs.simple.lrealVal = double.Parse(txtSimpleLreal.Text);
            cs.simple.dintVal = int.Parse(txtSimpleDint.Text);
            return cs;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //----write primitive data-------
                client.WriteAny(hint, short.Parse(txtINT.Text));
                client.WriteAny(hBool, Boolean.Parse(txtBool.Text));
                client.WriteAny(hDint1, int.Parse(txtDint.Text));
                client.WriteAny(hByte1, byte.Parse(txtByte.Text));
                client.WriteAny(hReal1, Single.Parse(txtReal.Text));
                client.WriteAny(hLreal1, double.Parse(txtLreal.Text));
                client.WriteAny(hstr1, txtStr1.Text,new int[] { 50});
                client.WriteAny(hstr2, txtStr2.Text, new int[] { 50 });
                //----write primitive data-------


                //-----write the struct dataType---------------
                client.WriteAny(hComplexStruct, GetStruct());
                //-----write the struct dataType---------------



            }
            catch (Exception err)
            {
                MessageBox.Show("Write all " + err.Message);
            }
            

        }
    }

    [StructLayout(LayoutKind.Sequential,Pack =0)]
    public class ComplexStruct
    {
        public short intVal;
        [MarshalAs(UnmanagedType.ByValArray,SizeConst =5)]
        public int[] dintArray = new int[5];

        [MarshalAs(UnmanagedType.I1)]
        public bool boolVal;

        public byte byteVal;

        public double lrealVal;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string stringVal = "";

        public SimpleStruct simple = new SimpleStruct();
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]        
        //public string[] strArrray = new string[3] { "","",""};
        // ??????how to read the string array from PLC?????
        
    }

    [StructLayout(LayoutKind.Sequential,Pack =0)]
    public class SimpleStruct
    {
        public double lrealVal;
        public int dintVal;
    }


     //
     //[StructLayout(LayoutKind.Sequential,Pack =0)]

     //[MarshalAs(UnmanagedType.ByValArray,SizeConst =4)]     //array
     //[MarshalAs(UnmanagedType.I1)]  //bool
     //[MarshalAs(UnmanagedType.ByValTStr,SizeConst =6)]


}
