using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aula6_AppXamarinFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitaMarvel : ContentPage
    {
        public CapitaMarvel()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Img.xamarin.png");
            poster.Source = ImageSource.FromResource("Aula6_AppXamarinFlix.Posters.capitamarvel.jpg");


            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' 
                                        height='300'
                                        src='https://www.youtube.com/embed/av2jODMFu6M' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; encrypted-media; gyroscope; 
                                               picture-in-picture' 
                                        allowfullscreen
                                </iframe>";

            visuzalizador.Source = htmlSource;

            sinopse.Text = "Em 1995, em Hala, capital do Império Kree localizada em um planeta de uma galáxia " +
                         "distante, Vers, uma mulher membro da Starforce, sofre de amnésia e pesadelos recorrentes " +
                         "envolvendo uma mulher mais velha.Yon - Rogg, seu mentor e comandante, treina-a para " +
                         "controlar suas habilidades, enquanto a Inteligência Suprema, que comanda artificialmente " +
                         "os Krees, ordena que ela mantenha suas emoções sob controle.";
        }
    }
}