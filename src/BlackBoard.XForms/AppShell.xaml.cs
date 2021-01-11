using Blackboard.ViewModels;
using Blackboard.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Blackboard
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
