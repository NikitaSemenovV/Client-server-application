using System;
using System.Windows.Forms;

namespace SomeProject.TcpClient
{
    static class EnteringPointClient
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientMainWindow());
        }
    }
}
