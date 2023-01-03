using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Buttons : ContentPage
	{
		public ICommand ButtonCommand => new Command<string>(CommandButtonClick);
		public Buttons ()
		{
			InitializeComponent ();
			BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			lblMessage.Text = "Save Success";
			lblMessage.TextColor= Color.White;
			lblMessage.TextTransform = TextTransform.Uppercase;
        }

		public void CommandButtonClick(string str)
		{
			lblMessage.Text = str;
		}

        private void Button_Clicked_1(object sender, EventArgs e)
        {
			DisplayAlert("Save", "Save Successfully", "OK");
        }
    }
}