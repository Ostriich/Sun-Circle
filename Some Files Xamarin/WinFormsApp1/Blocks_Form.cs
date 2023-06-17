using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.AspNetCore.SignalR.Client;

namespace WinFormsApp1
{
    public partial class Blocks_Form : Form
    {
        public Blocks_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        HubConnection hubConnection;

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Lines[0]!="")
            {

                int count = textBox1.Lines.Length;
                string[] catNames = new string[count];
                for (int i =0; i<count; i++)
                {
                    catNames[i] = textBox1.Lines[i];
                }

                if (hubConnection.State == HubConnectionState.Connected)
                {
                    hubConnection.SendAsync("RecieveDataOnServer", catNames);

                }

            }

            hubConnection = new HubConnectionBuilder().WithUrl("http://93.95.102.172/movehub").Build();
            try
            {
                hubConnection.StartAsync();
            }
            catch (System.Exception) { }
        }
        
    }
}
