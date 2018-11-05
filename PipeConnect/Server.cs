using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeConnect
{
    public partial class Server : Form
    {
        NamedPipeServerStream pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

        public Server()
        {
            
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            
            ThreadPool.QueueUserWorkItem(delegate {
                pipeServer.BeginWaitForConnection((o) => {
                    NamedPipeServerStream pServer = (NamedPipeServerStream)o.AsyncState;
                    pServer.EndWaitForConnection(o);
                    StreamReader sr = new StreamReader(pServer);
                    ContentBox.Text = sr.ReadToEnd();
                }, pipeServer);
            });
        
        }

        private void RunClientButton_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate {
                pipeServer.BeginWaitForConnection((o) => {
                    NamedPipeServerStream pServer = (NamedPipeServerStream)o.AsyncState;
                    pServer.EndWaitForConnection(o);
                    StreamReader sr = new StreamReader(pServer);
                    ContentBox.Text = sr.ReadToEnd();
                }, pipeServer);
            });
        }
    }
}
