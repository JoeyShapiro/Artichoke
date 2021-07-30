using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Artichoke.Models;
using Artichoke.Views;
using Artichoke.ViewModels;

namespace Artichoke.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        ListViewModel _viewModel;

        public ListPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}