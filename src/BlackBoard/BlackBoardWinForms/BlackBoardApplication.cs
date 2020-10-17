using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BlackBoardWinForms
{
    internal class BlackBoardApplication
    {
        // Client ID from the Azure Web Portal App Registration.
        private static string s_clientId = "963d0788-3eaf-4a00-b692-955e2f68de03";

        // 'common' - For Work, School and Microsoft personal accounts.
        // Can also be 'rganisations' (Work/School accounts),
        // 'consumers' (Personal MS accounts) or a particular tenent ID (GUID).
        private static string s_tenant = "common";

        // Hostname for the Azure AD instance. {0} will be replaced by the value of ida:Tenant below
        // You can change this URL if you want your application to sign-in users from other clouds
        // than the Azure Global Cloud (See national clouds / sovereign clouds at https://aka.ms/aadv2-national-clouds)
        private static string s_instance = "https://login.microsoftonline.com/{0}/v2.0";

        private static string s_scope = $"{s_clientId}/access_as_user";
        private static string s_authority = string.Format(CultureInfo.InvariantCulture, s_instance, s_tenant);
        private static string s_baseAddress = "http://127.0.0.1";

        private static IPublicClientApplication s_clientApp;

        static BlackBoardApplication()
        {
            var configOptions = new PublicClientApplicationOptions();
            configOptions.AadAuthorityAudience = AadAuthorityAudience.AzureAdMultipleOrgs;
            configOptions.AzureCloudInstance = AzureCloudInstance.AzurePublic;
            configOptions.ClientId = s_clientId;
            configOptions.RedirectUri = s_baseAddress;

            s_clientApp = PublicClientApplicationBuilder.Create(s_clientId)
                .WithAuthority(s_authority)
                .WithRedirectUri(s_baseAddress)
                .Build();
        }

        public static IPublicClientApplication PublicClientApp => s_clientApp;
        public static string[] Scopes { get; } = new[] { s_scope };
    }
}
