using CoffeeShop.Models;
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

            _viewModel = new AllProductsViewModel();

            BindingContext = _viewModel;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            _viewModel.OnAppearingCommand.Execute(null);
        }

        private void OnCoffeeSelected(object sender, EventArgs e)
        {
            var image = (Image)sender;

            var product = (Product) ((TapGestureRecognizer)image.GestureRecognizers[0]).CommandParameter;
            
            var detailView = new ProductDetailView(product);

            Navigation.PushAsync(detailView);
        }
    }
}
