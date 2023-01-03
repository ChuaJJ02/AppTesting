using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductInfoPage : ContentPage
	{
		public ProductInfoPage ()
		{
			InitializeComponent();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new AddOrEditProductPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
			ProductInfo productInfo = ((ProductInfoViewModel)BindingContext).ItemList.
				Where(prod => prod.ProductId == (int)tappedEventArgs.Parameter).FirstOrDefault();

			Navigation.PushAsync(new AddOrEditProductPage(productInfo));
        }

        private void Search1_TextChanged(object sender, TextChangedEventArgs e)
        {
			var searchresult = ProductInfoPage.Where(c => c.ProductName.Contains(Search1.Text));
			Items.ItemsSource = searchresult;
        }
    }
}