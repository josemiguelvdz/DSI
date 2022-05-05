using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Numerics;
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class Página1 : Page
    {
        Atributos atributos;
        public Página1()
        {
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            this.InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            atributos =(Atributos) e.Parameter;
            Diamonds.Text = atributos.getDiamantes().ToString();
            base.OnNavigatedTo(e);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // var window = Window.Current;
            // window.Close();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hub),atributos);
        }

        private void ConfigButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes),atributos);
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            Ofertas.Visibility = Visibility.Visible;
            OfertasDiamante.Visibility = Visibility.Visible;
            ShowDiamante.Visibility = Visibility.Visible;
            ShopButton.Visibility = Visibility.Collapsed;

            //if ((string)(sender as Button).Content == "0,99$")
            //    diamonds += 100;
            //else if((string)(sender as Button).Content == "4,99$")
            //    diamonds += 600;
            //else if ((string)(sender as Button).Content == "9,99$")
            //    diamonds += 1250;
            //else if ((string)(sender as Button).Content == "14,99$")
            //    diamonds += 2000;
            //else if ((string)(sender as Button).Content == "19,99$")
            //    diamonds += 2650;
            //else if ((string)(sender as Button).Content == "29,99$")
            //    diamonds += 4500;
            //else if ((string)(sender as Button).Content == "49,99$")
            //    diamonds += 10000;
            //else if ((string)(sender as Button).Content == "99,99$")
            //    diamonds += 22500;
            // DiamantesTotales.Text = diamonds.ToString();
        }

        private void ExitShopButton_Click(object sender, RoutedEventArgs e)
        {
            OfertasPala.Visibility = Visibility.Collapsed;
            OfertasRobot.Visibility = Visibility.Collapsed;
            OfertasDiamante.Visibility = Visibility.Collapsed;
            Ofertas.Visibility = Visibility.Collapsed;
            ShowDiamante.Visibility = Visibility.Collapsed;
            ShopButton.Visibility = Visibility.Visible;
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "OfertasDiamantes")
            {
                OfertasPala.Visibility = Visibility.Collapsed;
                OfertasRobot.Visibility = Visibility.Collapsed;
                OfertasDiamante.Visibility = Visibility.Visible;
            }
            else if ((sender as Button).Name == "OfertasSkins")
            {
                OfertasPala.Visibility = Visibility.Visible;
                OfertasRobot.Visibility = Visibility.Collapsed;
                OfertasDiamante.Visibility = Visibility.Collapsed;
            }
            else if ((sender as Button).Name == "OfertasLegend")
            {
                OfertasPala.Visibility = Visibility.Collapsed;
                OfertasRobot.Visibility = Visibility.Visible;
                OfertasDiamante.Visibility = Visibility.Collapsed;
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            atributos.setDiamantes(2000);
            Diamonds.Text = atributos.getDiamantes().ToString();
        }
    }
}
