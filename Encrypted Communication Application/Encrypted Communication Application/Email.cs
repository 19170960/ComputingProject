using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_Communication_Application
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            inbox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compose compose = new Compose();
            compose.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home1 = new Home();
            home1.Show();
        }
    }
}
