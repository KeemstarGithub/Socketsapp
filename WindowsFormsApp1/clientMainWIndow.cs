using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace WindowsFormsApp1
{
    public partial class clientConnected : Form
    {
        public clientConnected()
        {
            InitializeComponent();
            KeyPreview = true;
  
        }
        
        private void clientConnected_Load(object sender, EventArgs e)
        {
    
        }

        private void chatView(object sender, EventArgs e)
        {

        }
        
        private void userMessageField_TextChanged(object sender, EventArgs e)
        { 
            if (1 == 1)
            {

            }
        }

        private void enterKeypressDetection(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                chatViewList.Items.Add(userMessageField.Text);
                userMessageField.Text = "";
            }
            
     
        }
    }
}
