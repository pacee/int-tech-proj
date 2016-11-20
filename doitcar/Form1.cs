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
        }

        private int port;
        private IPAddress ip;
        private TcpClient client;
        private NetworkStream stream;
        private InstructionCollection collection;
        private List<Instruction> instructions;
        private List<int> route = new List<int>();

        private void Form1_Load(object sender, EventArgs e){
            txtIP.Text = "192.168.1.1";
            txtPort.Text = "9003";
            this.collection = new InstructionCollection();
            this.instructions = collection.getInstructions();
        }

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

        //Irányító gomb események
        private void btnStop_Click(object sender, EventArgs e)      { if (chkRoute.Checked) defineRoute(0); else sendCommand(0); }
        private void btnForward_Click(object sender, EventArgs e)   { if (chkRoute.Checked) defineRoute(1); else sendCommand(1); }
        private void btnBackward_Click(object sender, EventArgs e)  { if (chkRoute.Checked) defineRoute(2); else sendCommand(2); }
        private void btnLeft_Click(object sender, EventArgs e)      { if (chkRoute.Checked) defineRoute(3); else sendCommand(3); }
        private void btnRight_Click(object sender, EventArgs e)     { if (chkRoute.Checked) defineRoute(4); else sendCommand(4); }
        private void btnASpeedUp_Click(object sender, EventArgs e)  { if (chkRoute.Checked) defineRoute(5); else sendCommand(6); }
        private void btnBspeedUp_Click(object sender, EventArgs e)  { if (chkRoute.Checked) defineRoute(6); else sendCommand(7); }
        private void btnASpeedDown_Click(object sender, EventArgs e){ if (chkRoute.Checked) defineRoute(7); else sendCommand(8); }
        private void btnBSpeedDown_Click(object sender, EventArgs e){ if (chkRoute.Checked) defineRoute(8); else sendCommand(9); }

        //Parancs kódok küldése
        private void sendCommand(int commNumber){
            try{
                Byte[] command = System.Text.Encoding.ASCII.GetBytes(commNumber.ToString());
                this.stream = client.GetStream();
                this.stream.Write(command, 0, command.Length);  
            }catch(Exception exc){
                MessageBox.Show("Sending failed\n" + exc.Message);
                if (stream != null) stream.Close();
                if (client != null) client.Close();
            }
        }

        //Útvonal utasítások listába rakása
        private void defineRoute(int n){
            Instruction selected = instructions[n];
            this.txtbRoute.AppendText(selected.commDesc + "\n");
            this.route.Add(selected.commNumber);
        }

        //Útvonal lista elemeinek elküldése
        private void btnGO_Click(object sender, EventArgs e){
            foreach (var item in this.route){
                sendCommand(item);
            }
            this.route.Clear();
        }

        private void btnDisconnect_Click(object sender, EventArgs e){
            if (client != null) client.Close();       
            lblConnState.Text = "Disconnected";
        }
    }
}
