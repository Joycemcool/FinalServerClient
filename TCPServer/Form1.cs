using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ExitLibrary;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSend.Enabled = false;
            server = new SimpleTcpServer(textIPaddress.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }


        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                byte[] dataBytes = new byte[e.Data.Count];
                Array.Copy(e.Data.Array, e.Data.Offset, dataBytes, 0, e.Data.Count);
                string dataString = Encoding.UTF8.GetString(dataBytes);
                textConversation.Text += $"{e.IpPort}: {dataString}{Environment.NewLine}";
            });
           
        }

        //UI thread
        //Using delegate to create a small piece of code to be executed on the UI thread 
        //MethodInvoker is a delegate defined in the System.Windows.Forms namespace,
        //and it represents a method that takes no arguments and has no return value.
        //It's often used to marshal calls to the UI thread for updating the user interface
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textConversation.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                listBoxClientIP.Items.Remove(e.IpPort);
            });

        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textConversation.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                listBoxClientIP.Items.Add(e.IpPort);
            });

        }

        // allow the UI to remain responsive while the code within the Task.
        // Run block is running on a separate thread. 
        private async void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {    // Start the server on a separate thread using Task.Run
            //Task.Run is a way to execute a piece of code on a separate thread,
            //effectively creating a new task.
            await Task.Run(() =>
            {
                server.Start();//Thread 
                this.Invoke((MethodInvoker)delegate
                {
                    textConversation.Text = $"Starting...{Environment.NewLine}";
                    serverToolStripMenuItem.Enabled = false;
                    buttonSend.Enabled = true;
                });
            });
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if(!string.IsNullOrEmpty(textMessage.Text)&&listBoxClientIP.SelectedItem != null) 
                { 
                    server.Send(listBoxClientIP.SelectedItem.ToString(), textMessage.Text);//Thread 
                    textConversation.Text += $"Server: {textMessage.Text}{Environment.NewLine}";
                    textMessage.Text = string.Empty ;
                }
            }
        }

        private void textConversation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitFunction.ExitApplication(this);
        }
    }
}
