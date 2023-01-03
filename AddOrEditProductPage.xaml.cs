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
	public partial class AddOrEditProductPage : ContentPage
	{
		public AddOrEditProductPage (ProductInfo productInfo = null)
		{
			InitializeComponent ();
            if (productInfo != null)
            {
                ((AddOrEditProductViewModel)BindingContext).Product = productInfo;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
			ProductInfo product = ((AddOrEditProductViewModel)BindingContext).Product;
			if(product.ProductId == 0)
			{
				product.ImageURL = "images1.png";
			}
			MessagingCenter.Send(this, "AddOrEditProduct",product);

			Navigation.PopAsync();
        }
    }
}