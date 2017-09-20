using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class clientLogin : Form
    {
       
        public clientLogin()
        {
            InitializeComponent();
        }


        clientConnected cConnected = new clientConnected();
        joinServer jServer = new joinServer();
        private int validPort;
        private int validIP;
        bool alreadyused = false;

        public clientConnected CI;
        public void createNewClientInstance(ref clientConnected clientMenu)
        {
            clientMenu = new clientConnected();
            clientMenu.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void ipAddressField_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectPortField_TextChanged(object sender, EventArgs e)
        {

        }

        private void joinButton_Click(object sender, EventArgs e)
        {

            if (jServer.canJoin(ipAddressField.Text, connectPortField.Text) == true)
            {
                createNewClientInstance(ref CI);
            } else
            {
                MessageBox.Show("Invalid IP or Port!");
            }
            
     

                ipAddressField.Text = jServer.newIP.ToString();
                connectPortField.Text = jServer.newPort.ToString();
          
        
        }
    }
}
