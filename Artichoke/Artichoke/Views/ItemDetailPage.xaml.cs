using System.ComponentModel;
using Xamarin.Forms;
using Artichoke.ViewModels;

namespace Artichoke.Views
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