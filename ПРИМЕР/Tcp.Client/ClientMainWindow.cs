using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        public ClientMainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка отправки сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            OperationResult res = client.SendMessageToServer(textBox.Text);
            if(res.Result == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = "Message was sent succefully!";
                resBox.Text +="> " + res.Message + Environment.NewLine;
            }
            else
            {
                labelRes.Text = "Cannot send the message to the server.";
            }
            timer.Interval = 2000;
            timer.Start();
        }
        /// <summary>
        /// таймер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }
        /// <summary>
        ///  отправка файла на сервер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Client client = new Client();
                var res = client.SendFileToServer(fileDialog.FileName);
                if (res.Result == Result.OK)
                    labelRes.Text = "File was sent succefully!";
                else
                    labelRes.Text = "Cannot send the file to the server.";
                resBox.Text += "> " + res.Message + Environment.NewLine;
                timer.Interval = 2000;
                timer.Start();
            }
        }
    }
}
