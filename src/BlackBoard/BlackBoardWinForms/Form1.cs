using System;
using System.Linq;
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
            //var options = new SystemWebViewOptions()
            //{
            //    OpenBrowserAsync = new func<Uri,>
            //};

            try
            {
                var result = await BlackBoardApplication.TryLoginAsync();
                var userLoginInfo = await BlackBoardApplication.GetUserLoginInfoAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
