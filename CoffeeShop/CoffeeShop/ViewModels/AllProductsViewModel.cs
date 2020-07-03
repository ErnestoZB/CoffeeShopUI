using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoffeeShop.ViewModels
{
    public class AllProductsViewModel : BaseViewModel
    {
        private IList<Product> _products;
        public IList<Product> Products
        {
            get => _products;
            set => SetValue(ref _products, value);
        }

        public ICommand OnAppearingCommand { get; }
        public ICommand OnCoffeeSelectedCommand { get; }

        public AllProductsViewModel()
        {
            OnAppearingCommand = new Command(LoadItems);
        }

        private void LoadItems()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Name = "Colombia Del Campo",
                    Price = 98.50,
                    Image = "colombia_campo.png",
                    Description = "This blend is made up many small producer's who have farms on the side of Agua de Volcan at the edge on Antigua"
                },
                new Product
                {
                    Name = "Crossfade Blend",
                    Price = 103,
                    Image = "crossfade_blend.png",
                    Description = "Our ride-or-die espresso blend. We use Crossfade as a utility espresso in our cafes. Great with milk, americanos, or neat"
                }
            };

        }
    }
}
