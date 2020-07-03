using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public ProductDetailViewModel(Product product)
        {
            Product = product;
        }
    }
}
