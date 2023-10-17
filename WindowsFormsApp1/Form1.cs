using ExitLibrary;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(textIPaddress.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_DisConnected;
            buttonSend.Enabled = false;
        }

        private void Events_DisConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textConversation.Text += $"Server disconnected.{Environment.NewLine}";

            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                byte[] dataBytes = new byte[e.Data.Count];
                Array.Copy(e.Data.Array, e.Data.Offset, dataBytes, 0, e.Data.Count);
                string dataString = Encoding.UTF8.GetString(dataBytes);
                textConversation.Text += $"Server: {dataString}{Environment.NewLine}";
            });
          
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textConversation.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(textMessage.Text))
                {
                    client.Send(textMessage.Text);
                    textConversation.Text = $"Me: {textMessage.Text}{Environment.NewLine}";
                    textMessage.Text = string.Empty ;

                }
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                buttonSend.Enabled = true;
                clientToolStripMenuItem.Enabled = false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error );    
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitFunction.ExitApplication(this);
        }

        private void textIPaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
