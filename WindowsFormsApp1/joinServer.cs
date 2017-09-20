using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace WindowsFormsApp1
{
    class joinServer
    {
        public string newIP;
        public int newPort;

        private int isPortValid(string serverPort) // Checks if port can be converted to INT. Sets port value to 0 if port is not valid.
        {
           
            if(Int32.TryParse(serverPort, out newPort))
            {
                return newPort;
            }

            else
            {
                return 0;
            }
        }

       private string isIPValid(string serverIP) // Checks if input can be treated as an IP. Not accurat
        {
            int result;
            if(Int32.TryParse(serverIP, out result))
            {
                return result.ToString();
            }
            else
            {
                return serverIP;
            }
        }

        

        public bool canJoin(string serverIP, string serverPort)
        {
            if(isIPValid(serverIP) != null && isPortValid(serverPort) != 0)
            {
                newIP = isIPValid(serverIP);
                newPort = isPortValid(serverPort);
    
                return true;
            }

            else
            {
                newIP = isIPValid(serverIP);
                newPort = isPortValid(serverPort);
                return false;
            }
        }
    }
}
