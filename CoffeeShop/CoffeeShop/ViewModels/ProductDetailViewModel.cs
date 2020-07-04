using CoffeeShop.Models;
using CoffeeShop.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoffeeShop.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        private Product _product;
        public Product Product
        {
            get => _product;
            set => SetValue(ref _product, value);
        }

        public ICommand BackCommand { get;  }

        private readonly INavigationService _navigationService;

        public ProductDetailViewModel(INavigationService navigationService, Product product)
        {
            _navigationService = navigationService;

            Product = product;

            BackCommand = new Command(async vm => await OnBackClicked());
        }

        private async Task OnBackClicked()
        {
            await _navigationService.PopAsync();
        }
    }
}
