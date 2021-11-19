using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PM2FoursquareApiAD.Views
{
    public partial class FourSquarePage : ContentPage
    {
        public FourSquarePage()
        {
            InitializeComponent();
        }

        private async void btnsquare_Clicked(System.Object sender, System.EventArgs e)
        {
            List<Models.ApiFoursquare.Venue> sitioscerca = new List<Models.ApiFoursquare.Venue>();

            sitioscerca = await Controller.FoursquareController.getListSite(14.0984, -87.2061);

            listaSitios.ItemsSource = sitioscerca;
        }
    }
}
