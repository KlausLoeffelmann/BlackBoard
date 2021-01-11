using Microsoft.Identity.Client.Extensibility;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoardWinForms
{
    public partial class frmWebLogin : Form, ICustomWebUi
    {
        private TaskCompletionSource _browserInitializationAwaiter = new TaskCompletionSource();
        private TaskCompletionSource<Uri> _browserNavigationCompletedAwaiter = new TaskCompletionSource<Uri>();
        private TaskCompletionSource<Uri> _loginOverAwaiter = new TaskCompletionSource<Uri>();

        private object _browserInitializationAwaiterGuard = new object();
        private Uri _redirectUri;

        public frmWebLogin()
        {
            InitializeComponent();
            loginWebView.CoreWebView2Ready += LoginWebView_CoreWebView2Ready;
            tsEndLoginButton.ButtonClick += TsEndLoginButton_ButtonClick;
            this.SizeChanged += FrmWebLogin_SizeChanged;
        }

        private void FrmWebLogin_SizeChanged(object sender, EventArgs e) 
            => tsSizeLabel.Text = $"Size: {Size}";

        private void LoginWebView_CoreWebView2Ready(object sender, EventArgs e)
        {
            _browserInitializationAwaiter.TrySetResult();
            loginWebView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }

        private void CoreWebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Debug.WriteLine($"NavigationCompleted-Success: {e.IsSuccess}");
            Debug.WriteLine($"NavigationCompleted-Navigation ID: {e.NavigationId}");

            tsUriLabel.Text = $"{loginWebView.CoreWebView2.Source}";
            tsUriLabel.ToolTipText = tsUriLabel.Text;

            if (_browserNavigationCompletedAwaiter != null)
            {
                _browserNavigationCompletedAwaiter.TrySetResult(new Uri(loginWebView.CoreWebView2.Source));
            }

            if (loginWebView.CoreWebView2.Source.ToString().StartsWith(_redirectUri.ToString()))
            {
                _loginOverAwaiter.TrySetResult(loginWebView.Source);
            }
        }

        public void NavigateTo(Uri uri)
        {
            loginWebView.CoreWebView2.Navigate(uri.ToString());
        }

        public async Task WaitForInitializeAsync()
        {
            try
            {
                await loginWebView.EnsureCoreWebView2Async(null).ConfigureAwait(false);
                await _browserInitializationAwaiter.Task.ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex}");
                throw;
            }
        }

        public async Task<Uri> AcquireAuthorizationCodeAsync(Uri authorizationUri, Uri redirectUri, CancellationToken cancellationToken)
        {
            _redirectUri = redirectUri;

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { NavigateTo(authorizationUri); });
            }

            return await _loginOverAwaiter.Task;
        }

        private void TsEndLoginButton_ButtonClick(object sender, EventArgs e)
        {
            Close();
            _loginOverAwaiter.TrySetResult(loginWebView.Source);
        }
    }
}
