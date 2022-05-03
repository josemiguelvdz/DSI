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
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class Página1 : Page
    {
        private int diamonds=500;
        public Página1()
        {
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            this.InitializeComponent();
            DiamantesTotales.Text = diamonds.ToString();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is int)
            {
                diamonds = (int)e.Parameter;
                DiamantesTotales.Text = diamonds.ToString();
            }
            base.OnNavigatedTo(e);
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // var window = Window.Current;
            // window.Close();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hub),diamonds);
        }

        private void ConfigButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Graficos));
        }
        private void Tienda_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Ofertas.Visibility = Visibility.Visible;
            OfertasDiamante.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)(sender as Button).Content == "0,99$")
                diamonds += 100;
            else if((string)(sender as Button).Content == "4,99$")
                diamonds += 600;
            else if ((string)(sender as Button).Content == "9,99$")
                diamonds += 1250;
            else if ((string)(sender as Button).Content == "14,99$")
                diamonds += 2000;
            else if ((string)(sender as Button).Content == "19,99$")
                diamonds += 2650;
            else if ((string)(sender as Button).Content == "29,99$")
                diamonds += 4500;
            else if ((string)(sender as Button).Content == "49,99$")
                diamonds += 10000;
            else if ((string)(sender as Button).Content == "99,99$")
                diamonds += 22500;
            DiamantesTotales.Text = diamonds.ToString();
        }

        private async void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if((sender as Image).Name == "SalirTienda")
            {
                OfertasPala.Visibility = Visibility.Collapsed;
                OfertasRobot.Visibility = Visibility.Collapsed;
                OfertasDiamante.Visibility = Visibility.Collapsed;
                Ofertas.Visibility = Visibility.Collapsed;
            }
            if((sender as Image).Name == "OfertasDiamantes")
            {
                OfertasPala.Visibility = Visibility.Collapsed;
                OfertasRobot.Visibility = Visibility.Collapsed;
                OfertasDiamante.Visibility = Visibility.Visible;
            }
            else if ((sender as Image).Name == "OfertasPalas")
            {
                OfertasPala.Visibility = Visibility.Visible;
                OfertasRobot.Visibility = Visibility.Collapsed;
                OfertasDiamante.Visibility = Visibility.Collapsed;
            }
            else if ((sender as Image).Name == "OfertasRobots")
            {
                OfertasPala.Visibility = Visibility.Collapsed;
                OfertasRobot.Visibility = Visibility.Visible;
                OfertasDiamante.Visibility = Visibility.Collapsed;
            }
        }
    }
}
