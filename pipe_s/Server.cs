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

namespace pipe_s
{
    public partial class Server : Form
    {
        NamedPipeServerStream pipeServer = new NamedPipeServerStream("Server", PipeDirection.In);
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            pipeServer.WaitForConnection();
            try
            {
                StreamReader sr = new StreamReader(pipeServer);
                ContentBox.Text = sr.ReadToEnd();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
