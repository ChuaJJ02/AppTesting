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
    public partial class Entries : ContentPage
    {
        public Entries()
        {
            InitializeComponent();
            txtName.Text = "Testing Run";
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblValue.Text = ((Entry)sender).Text;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblValue.Text = e.NewTextValue;
        }
    }
}