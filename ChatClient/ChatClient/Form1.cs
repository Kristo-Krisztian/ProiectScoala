using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serverStream == null)
                return;
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(clientTxt.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            clientTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /* IP parse shit */
            string input = maskedTextBox1.Text ;
            if (input.Contains(" "))
                input = input.Replace(" ", "");
            string[] ipParts = input.Split('.');
            int[] ipPartsC = new int[ipParts.Length];
            for (int x = 0; x < ipParts.Length; x++)
            {
                ipPartsC[x] = Convert.ToInt32(ipParts[x]);
            }
            string ipParsed = ipPartsC[0] + "." + ipPartsC[1] + "." + ipPartsC[2] + "."  + ipPartsC[3];

            try
            {
                msg();
                clientSocket.Connect(ipParsed, 8888);
                readData = "Conected to Chat Server ...";
                serverStream = clientSocket.GetStream();

                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(chatName.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                Thread ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(), "SocketException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                serverTxt.Text = serverTxt.Text + Environment.NewLine + " >> " + readData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            serverTxt.SelectionStart = serverTxt.Text.Length;
            serverTxt.ScrollToCaret();
        }

    }
}