using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace doitcar{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
            txtIP.Text = "192.168.4.1";
            txtPort.Text = "9003";
            txtMultipler.Text = "10";
            lsbCommands.SelectedIndex = 0;
        }
        
        private int port;
        private IPAddress ip;
        private TcpClient client;
        private NetworkStream stream;

        //Csatlakozás a kocsihoz/serverhez
        private void btnConnect_Click(object sender, EventArgs e){
            try {
                this.port = Convert.ToInt32(txtPort.Text);
                this.ip = IPAddress.Parse(txtIP.Text);
                this.client = new TcpClient();
                client.Connect(ip, port);
                lblConnState.Text = "Connected";
            }catch(Exception exc){
                MessageBox.Show("Connection failed\n" + exc.Message.ToString());
            }
        }

        //Kézi parancsküldés
        private void btnSend_Click(object sender, EventArgs e){
            int commNumber = Convert.ToInt32(lsbCommands.SelectedItem);
            int n = Convert.ToInt32(txtMultipler.Text);
            sendCommand(commNumber, n);
        }

        //Irányító gomb események
        private void btnStop_Click(object sender, EventArgs e)      {   sendCommand(0, 1);                                  }
        private void btnForward_Click(object sender, EventArgs e)   {   sendCommand(1, Convert.ToInt32(txtMultipler.Text)); }
        private void btnBackward_Click(object sender, EventArgs e)  {   sendCommand(2, Convert.ToInt32(txtMultipler.Text)); }
        private void btnLeft_Click(object sender, EventArgs e)      {   sendCommand(3, Convert.ToInt32(txtMultipler.Text)); }
        private void btnRight_Click(object sender, EventArgs e)     {   sendCommand(4, Convert.ToInt32(txtMultipler.Text)); }    

        //Parancs kódok küldése n-szer
        private void sendCommand(int commNumber, int n){
            try{
                Byte[] command = System.Text.Encoding.ASCII.GetBytes(commNumber.ToString());
                this.stream = client.GetStream();
                for (int i = 0; i < n; i++){
                    this.stream.Write(command, 0, command.Length);
                }
            }catch(Exception exc){
                MessageBox.Show("Sending failed\n" + exc.Message);
                if (stream != null) stream.Close();
                if (client != null) client.Close();
            }
        }     
    }
}
