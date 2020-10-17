using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            var publicClientApp = BlackBoardApplication.PublicClientApp;
            try
            {
                var accounts = (await publicClientApp.GetAccountsAsync()).ToList();

                var authResult = await publicClientApp.AcquireTokenInteractive(BlackBoardApplication.Scopes)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
