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

namespace clientchat
{
    public partial class Cliente : Form
    {
        SimpleTcpClient client;
        public Cliente()
        {
            InitializeComponent();
        }

      
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            btn_connect.Enabled = true;
            lbl_Status.Text = "Se ha desconectado del Servidor";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Status.Text = "";
                client.Connect(txt_host.Text, Convert.ToInt32(txt_port.Text));
                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message +" - Error en la conexion servidor esta desconectado o host incorrecto");
            }
           
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            btn_disconnect.Enabled = false;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            lbl_Status.Invoke((MethodInvoker)delegate ()
            {
                lbl_Status.Text += e.MessageString;
              
            });
        }

        private void btn_msg_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txt_nick.Text+" :"+txt_msg.Text, TimeSpan.FromSeconds(1));
            txt_msg.Clear();
        }
    }
}
