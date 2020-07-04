using CoffeeShop.Models;
using CoffeeShop.Services;
using CoffeeShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailView : ContentPage
    {
        private readonly ProductDetailViewModel _viewModel;

        public ProductDetailView(Product product)
        {
            InitializeComponent();

            _viewModel = new ProductDetailViewModel(new NavigationService(), product);

            BindingContext = _viewModel;
        }
    }
}