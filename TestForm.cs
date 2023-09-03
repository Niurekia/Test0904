using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _01BASIC
{
    public partial class winform : Form
    {

        private SerialPort serialPort = new SerialPort();

        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("HELLO WORLD");
            //Console.WriteLine("sender : " + sender);
            //Console.WriteLine("EventArgs : " + e);
            ComboBox cb = (ComboBox)sender;
            
            Console.WriteLine((cb.SelectedIndex+1)+"번째 포트가 선택되었습니다\r\n"+"선택된 포트 : " + cb.Items[cb.SelectedIndex]);

        }

       /* private void SerialPort_DataRecv(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.WriteLine(recvData);
        }*/

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Conn_Btn Click : " + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()); ;
            try
            {
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.serialPort.BaudRate = 9600;
                this.serialPort.DataBits = 8;
                this.serialPort.StopBits = System.IO.Ports.StopBits.One;
                this.serialPort.Parity = System.IO.Ports.Parity.None;
                this.serialPort.Open();
                Console.WriteLine("CONNECTION SUCCESS");
                this.textArea.AppendText("Connected \r\n");
                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.serialPort.Close();
                this.textArea.AppendText("Fail...." + ex + "\r\n");
            }


        }

        private void SerialPort_DataReceived(object sender, EventArgs e)
        {
            String recvData = this.serialPort.ReadLine();
            Console.WriteLine(recvData);
            //스레드 생성 코드
            /*Invoke(new Action(()=>{
                *//*처리로직*//*
            }
            ));*/
            //LED 점등 유무 확인 스레드
            if (recvData.StartsWith("Led"))
            {
                Invoke(new Action(() =>
                {
                    /*Console.WriteLine(recvData);*/
                    this.textArea.AppendText(recvData + "\r\n");
                }));
            }
            //온도 센서 확인 스레드
            if (recvData.StartsWith("Temp:"))
            {
                Invoke(new Action(() =>
            {
                this.TempBox.Text = ""; 
                this.TempBox.Text = recvData.Replace("Temp:","");
            }));
            }

            //조도 센서 확인 스레드
            if (recvData.StartsWith("SUN :"))
            {
                Invoke(new Action(() =>
                {
                    this.sunText.Text = "";
                    this.sunText.Text = recvData.Replace("SUN :", "");
                }));
            }

            //초음파 센서 확인 스레드
            if (recvData.StartsWith("Distance:"))
            {
                Invoke(new Action(() =>
                {
                    this.US_Text.Text = "";
                    this.US_Text.Text = recvData.Replace("Distance:", "");
                }));
            }
        }



        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void winform_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }
    }
}