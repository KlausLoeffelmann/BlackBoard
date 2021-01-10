using Microsoft.Identity.Client;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoardWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var loginBrowser = new frmWebLogin();
                loginBrowser.Show();
                await loginBrowser.WaitForInitializeAsync();
                BlackBoardApplication.Initialize();
                var result = await BlackBoardApplication.TryLoginAsync(loginBrowser);
                loginBrowser.Close();
                var userLoginInfo = await BlackBoardApplication.GetUserLoginInfoAsync();

                txtBlackboard.Text = userLoginInfo.Blackboard;
                lblLoginInfo.Text = $"{userLoginInfo.Name} - ({userLoginInfo.UserId})";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var webBrowser = new frmWebLogin();
            webBrowser.Show();
            await webBrowser.WaitForInitializeAsync();
            webBrowser.NavigateTo(new Uri("https://www.heise.de/"));
        }
    }
}
