using Blackboard.ClientServices.ViewModels;
using System;
using System.Windows.Forms;

namespace BlackBoardWinForms
{
    public partial class Form1 : Form
    {
        private LoginViewModel _loginViewModel = new LoginViewModel();

        public Form1()
        {
            InitializeComponent();
            _loginViewModel.Initialize();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var loginBrowser = new frmWebLogin();
                loginBrowser.Show();
                await loginBrowser.WaitForInitializeAsync();
                var result = await _loginViewModel.LoginAsync(loginBrowser);
                loginBrowser.Close();

                // Populate Data.
                loginViewModelBindingSource.DataSource = _loginViewModel;
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
