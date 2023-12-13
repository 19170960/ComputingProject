using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Encrypted_Communication_Application
{
    public partial class SMS : Form

    {
        int portSource = 44444;
        int portDestination = 55555;

        UdpClient serverUDP;
        IPEndPoint ipAddressDestination;
        
        public SMS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SMS_Load(object sender, EventArgs e)
        {

        
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home2 = new Home();
            home2.Show();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReceiveDisplayMessage(IAsyncResult AR)
        {
            byte[] messageBuffer = serverUDP.EndReceive(AR, ref ipAddressDestination);
            serverUDP.BeginReceive(new AsyncCallback(ReceiveDisplayMessage), serverUDP);
            richTextBox1.AppendText("> " + Encoding.ASCII.GetString(messageBuffer) + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serverUDP = new UdpClient(portSource);
            ipAddressDestination = new IPEndPoint(IPAddress.Parse(textBox4.Text), portDestination);
            serverUDP.BeginReceive(new AsyncCallback(ReceiveDisplayMessage), serverUDP);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverUDP.Connect(ipAddressDestination);
            serverUDP.Send(Encoding.ASCII.GetBytes(textBox1.Text), textBox1.Text.Length);
            textBox1.Clear();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
