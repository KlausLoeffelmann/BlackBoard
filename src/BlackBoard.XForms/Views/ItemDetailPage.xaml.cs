using BlackBoard.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BlackBoard.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}