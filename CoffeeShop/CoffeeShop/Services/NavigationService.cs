using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeShop.Services
{
    public class NavigationService : INavigationService
    {
        public async Task PopAsync()
        {
            var navigation = Application.Current.MainPage as NavigationPage;

            await navigation.PopAsync();
        }

        public async Task PushAsync(Page page)
        {
            var navigation = Application.Current.MainPage as NavigationPage;

            await navigation.PushAsync(page);
        }
    }
}