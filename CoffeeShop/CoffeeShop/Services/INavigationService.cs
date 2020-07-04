using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeShop.Services
{
    public interface INavigationService
    {
        Task PopAsync();

        Task PushAsync(Page page);
    }
}
