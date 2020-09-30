using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Aula6_AppXamarinFlix.Filmes;

namespace Aula6_AppXamarinFlix.Categoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Img.xamarin.png");


            btnAlladin.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.alladin.jpg");
            btnCapitaMarvel.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.capitamarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.panteranegra.jpg");
            btnShazam.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.shazam.jpg");
            btnDumbo.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.dumbo.jpg");
            btnVef.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.vef.jpg");
        }

        private async void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CapitaMarvel());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}