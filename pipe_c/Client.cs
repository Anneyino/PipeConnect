using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;

namespace pipe_c
{
    public partial class Client : Form
    {

        NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "Server", PipeDirection.Out);
        public Client()
        {     
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {   
            try
            {
                StreamWriter sw = new StreamWriter(pipeClient);
                sw.AutoFlush = true;
                sw.WriteLine(ContentBox.Text);
                sw.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {   
            pipeClient.Connect();
        }
    }
}
