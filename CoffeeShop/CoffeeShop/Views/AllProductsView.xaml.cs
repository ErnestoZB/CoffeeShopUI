using CoffeeShop.Models;
using CoffeeShop.Services;
using CoffeeShop.ViewModels;
using CoffeeShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeShop
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AllProductsView : ContentPage
    {
        private readonly AllProductsViewModel _viewModel;
        public AllProductsView()
        {
            InitializeComponent();

            _viewModel = new AllProductsViewModel(new NavigationService());

            BindingContext = _viewModel;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            _viewModel.OnAppearingCommand.Execute(null);
        }

        private void OnProductTapped(object sender, EventArgs e)
        {
            _viewModel.ProductSelectedCommand.Execute(null);
        }
    }
}
