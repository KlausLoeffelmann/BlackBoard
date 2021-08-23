using Blackboard.WinForms;
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
            _loginViewModel.PropertyChanged += _loginViewModel_PropertyChanged;
        }

        private void _loginViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_loginViewModel.LoginInfo))
            {
                tslLoginInfo.Text = _loginViewModel.LoginInfo;
            }
            else if (e.PropertyName == nameof(_loginViewModel.LastHttpStatus))
            {
                tslLastHttpResponse.Text = _loginViewModel.LastHttpStatus;
            }
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await _loginViewModel.UpdateBlackboardAsync();
        }
    }
}
