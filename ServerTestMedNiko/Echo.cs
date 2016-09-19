using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestMedNiko
{
    class Echo
    {
        private TcpClient connectionseet;

        public Echo(TcpClient connectionseet)
        {
            this.connectionseet = connectionseet;
        }

        internal void Message()
        {
            Stream connectionStream = connectionseet.GetStream();


            StreamReader sReader = new StreamReader(connectionStream);
            StreamWriter sWriter = new StreamWriter(connectionStream);
            sWriter.AutoFlush = true;
            string message = "q";

            while (message.ToLower() != "stop")
           {
                message = sReader.ReadLine();

                Console.WriteLine(message);

                //string response = Console.ReadLine();

                sWriter.WriteLine(message.ToUpper() + " Nu Er Jeg Ekoo MHUHAHAH");
            }
          



          

            

        }

    }
}
