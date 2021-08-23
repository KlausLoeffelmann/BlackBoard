using Blackboard.ClientServices.ViewModels;
using Blackboard.Models;
using Blackboard.ViewModels;
using Blackboard.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Blackboard.Views
{
    public partial class MainPage : ContentPage
    {
        LoginViewModel _loginViewModel;

        public MainPage()
        {
            InitializeComponent();

            _loginViewModel = new LoginViewModel();
            BindingContext = _loginViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}