using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace serverchat
{
    public partial class Server : Form
    {
        SimpleTcpServer server;
        public Server()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "";

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txt_host.Text);
            server.Start(ip, Convert.ToInt32(txt_port.Text));
            lbl_Status.Text = "El servidor esta corriendo";
            btn_stop.Enabled = true;
            btn_start.Enabled = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "";
            if (server.IsStarted)
                server.Stop();

            lbl_Status.Text = "El Servidor esta detenido";
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btn_stop.Enabled = false;
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientDisconnected(object sender, System.Net.Sockets.TcpClient e)
        {
            lbl_contador.Invoke((MethodInvoker)delegate ()
            {
                lbl_contador.Text = Convert.ToString(server.ConnectedClientsCount);
            });
        }

        private void Server_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
        {
            lbl_contador.Invoke((MethodInvoker)delegate ()
            {
                lbl_contador.Text = Convert.ToString(server.ConnectedClientsCount);
            });
            
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            lbl_Status.Invoke((MethodInvoker)delegate ()
            {
                lbl_Status.Text += e.MessageString;
                server.BroadcastLine(e.MessageString);
              //  e.ReplyLine(string.Format(e.MessageString));
            });
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            server.BroadcastLine("Mensaje del Servidor: "+txt_msg.Text);
            txt_msg.Clear();
        }
    }
}
