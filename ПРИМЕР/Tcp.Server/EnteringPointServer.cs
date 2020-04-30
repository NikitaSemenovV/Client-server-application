using System;
using SomeProject.Library.Server;

namespace SomeProject.TcpServer
{
    class EnteringPointServer
    {
        static void Main(string[] args)
        {
           try
            {
                Server server = new Server();
                server.TurnOnListener().Wait();
                
                //server.turnOffListener();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
