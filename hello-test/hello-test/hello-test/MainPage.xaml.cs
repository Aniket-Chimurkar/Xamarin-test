using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hello_test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Aniket_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sucess!", "successfully Logged In", "Ok");
        }
    }
}
