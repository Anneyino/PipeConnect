using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMachine
{
    public partial class Client : Form
    {
        NamedPipeClientStream pipeClient = new NamedPipeClientStream("localhost", "testpipe", PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.None);
        StreamWriter sw = null;
        public Client()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (sw != null)
            {
                sw.WriteLine(ContentBox.Text);
            }
            else
            {
                MessageBox.Show("Connection Error");
                this.Close();
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                pipeClient.Connect(5000);
                sw = new StreamWriter(pipeClient);
                sw.AutoFlush = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接建立失败，请确保服务端程序已经被打开。");
                this.Close();
            }
        }
    }
}
