using Blackboard.ViewModels;
using BlackboardWebApi.Model;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensibility;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;

#if NETSTANDARD2_0
namespace Blackboard.ClientServices.ViewModels
#else
using Blackboard.ClientServices;

namespace Blackboard.WinForms
#endif
{
    public class LoginViewModel : BaseViewModel
    {
        // Client ID from the Azure Web Portal App Registration.
        private static string s_clientId = "963d0788-3eaf-4a00-b692-955e2f68de03";
        private static readonly string s_scope = $"{s_clientId}/access_as_user";
        internal static string[] Scopes { get; } = new[] { s_scope };

        internal static string WebApi_UserInfo => $"{s_webApiBaseAddress}/api/userinfo";


        // 'common' - For Work, School and Microsoft personal accounts.
        // Can also be 'rganisations' (Work/School accounts),
        // 'consumers' (Personal MS accounts) or a particular tenent ID (GUID).
        private static readonly string s_tenant = "common";

        // Hostname for the Azure AD instance. {0} will be replaced by the value of ida:Tenant below
        // You can change this URL if you want your application to sign-in users from other clouds
        // than the Azure Global Cloud (See national clouds / sovereign clouds at https://aka.ms/aadv2-national-clouds)
        private static readonly string s_instance = "https://login.microsoftonline.com/{0}/v2.0";

        private static readonly string s_authority = string.Format(CultureInfo.InvariantCulture, s_instance, s_tenant);

        // change this to the Azure Web App address for deployment.
        private static readonly string s_webApiBaseAddress = "https://localhost:44351";
        // private static readonly string s_webApiBaseAddress = "https://blackboardwebapi.azurewebsites.net";

        private IPublicClientApplication _clientApp;
        private bool _isLoggedIn;
        private string _loginStatus;
        private string _frontPageContent;
        private string _loginInfo;
        private string _lastHttpStatus;

        private HttpClient HttpClient { get; } = new HttpClient();
        public IPublicClientApplication PublicClientApp => _clientApp;

        public void Initialize()
        {
            _clientApp = PublicClientApplicationBuilder.Create(s_clientId)
                .WithAuthority(s_authority)
                .WithDefaultRedirectUri()
                .Build();

#if NET5_0
            TokenCacheHelper.EnableSerialization(_clientApp.UserTokenCache);
#endif
        }

        internal async Task ClearAccountsAsync(IEnumerable<IAccount> accounts)
        {
            foreach (var account in accounts)
            {
                await PublicClientApp.RemoveAsync(account);
            }
        }

        public async Task UpdateBlackboardAsync()
        {
            if (IsLoggedIn)
            {
                var jsonBlackboard = JsonConvert.SerializeObject(FrontPageContent);
                var content = new StringContent(jsonBlackboard, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClient.PutAsync(WebApi_UserInfo, content);
                UpdateStatus(response);
            }
        }

        private void UpdateStatus(HttpResponseMessage response)
        {
            LastHttpStatus = $"{response.StatusCode} - {response.ReasonPhrase}";
        }

        private async Task<UserInfo> GetUserLoginInfoAsync()
        {
            if (IsLoggedIn)
            {
                HttpResponseMessage response = await HttpClient.GetAsync(WebApi_UserInfo);
                if (response.IsSuccessStatusCode)
                {
                    UpdateStatus(response);
                    string s = await response.Content.ReadAsStringAsync();
                    var userLoginInfo = JsonConvert.DeserializeObject<UserInfo>(s);

                    return userLoginInfo;
                }
            }

            return null;
        }

        public async Task<AuthenticationResult> LoginAsync(ICustomWebUi webLoginFormCreatedOnUIThread)
        {
            var accounts = (await PublicClientApp.GetAccountsAsync()).ToList();

            if (accounts?.Count > 0)
            {
                await ClearAccountsAsync(accounts);
            }

            AuthenticationResult authResult = null;

            try
            {
                authResult = await PublicClientApp.AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
                    .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                try
                {
                    authResult = await PublicClientApp.AcquireTokenInteractive(Scopes)
                        .WithCustomWebUi(webLoginFormCreatedOnUIThread)
                        .ExecuteAsync();
                }
                catch (System.Exception)
                {
                    // TODO: Implement error handling.
                }
            }

            if (authResult.AccessToken != null)
            {
                // Once the token has been returned by MSAL, add it to the http authorization header, before making the call to access the To Do list service.
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);
                IsLoggedIn = true;

                // Now get the Info from the WebService to fill the Data of the ViewModel.
                var userInfo = await GetUserLoginInfoAsync();
                LoginInfo = $"{userInfo.Name} - {userInfo.PreferredUserName}";
                FrontPageContent = userInfo.FrontPage;
            }
            else
            {
                IsLoggedIn = false;
            }

            return authResult;
        }

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set => SetProperty(
                   ref _isLoggedIn,
                   value,
                   onChanged: () => LoginStatus = value ? "Logged in." : "Login failed.");
        }

        public string LoginStatus
        {
            get { return _loginStatus; }
            set { SetProperty(ref _loginStatus, value); }
        }

        public string LoginInfo
        {
            get { return _loginInfo; }
            set { SetProperty(ref _loginInfo, value); }
        }

        public string LastHttpStatus
        {
            get { return _lastHttpStatus; }
            set { SetProperty(ref _lastHttpStatus, value); }
        }

        public string FrontPageContent
        {
            get { return _frontPageContent; }
            set { SetProperty(ref _frontPageContent, value); }
        }
    }
}
