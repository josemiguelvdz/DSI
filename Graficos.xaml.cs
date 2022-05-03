using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class Graficos : Page
    {

        public Graficos()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void SonidosKeyDown(object sender, RoutedEventArgs e)
        {
            if (GraficosIzquierda.Visibility == Visibility.Visible)
            {
                StackPanel o = (FindName("GraficosDerecha") as Grid).Children[0] as StackPanel; 

                GraficosIzquierda.Visibility = Visibility.Collapsed;
                GraficosDerecha.Visibility = Visibility.Collapsed;


                Sonido_.Foreground = Graficos_.Foreground;
                Graficos_.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (IdiomaIzquierda.Visibility == Visibility.Visible)
            {
                IdiomaIzquierda.Visibility = Visibility.Collapsed;
                IdiomaDerecha.Visibility = Visibility.Collapsed;

                Avanza1Derecha.Visibility = Visibility.Visible;
                Avanza4Derecha.Visibility = Visibility.Visible;
                Avanza1Izquierda.Visibility = Visibility.Visible;
                Avanza4Izquierda.Visibility = Visibility.Visible;

                Sonido_.Foreground = Idioma_.Foreground;
                Idioma_.Foreground = new SolidColorBrush(Colors.Black);
            }

            SonidoIzquierda.Visibility = Visibility.Visible;
            SonidoDerecha.Visibility = Visibility.Visible;

        }

        private void IdiomasKeyDown(object sender, RoutedEventArgs e)
        {
            if (GraficosIzquierda.Visibility == Visibility.Visible)
            {
                GraficosIzquierda.Visibility = Visibility.Collapsed;
                GraficosDerecha.Visibility = Visibility.Collapsed;

                Idioma_.Foreground = Graficos_.Foreground;
                Graficos_.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (SonidoIzquierda.Visibility == Visibility.Visible)
            {
                SonidoIzquierda.Visibility = Visibility.Collapsed;
                SonidoDerecha.Visibility = Visibility.Collapsed;

                Idioma_.Foreground = Sonido_.Foreground;
                Sonido_.Foreground = new SolidColorBrush(Colors.Black);
            }

            Avanza1Derecha.Visibility = Visibility.Collapsed;
            Avanza2Derecha.Visibility = Visibility.Collapsed;
            Avanza4Derecha.Visibility = Visibility.Collapsed;
            Avanza1Izquierda.Visibility = Visibility.Collapsed;
            Avanza2Izquierda.Visibility = Visibility.Collapsed;
            Avanza4Izquierda.Visibility = Visibility.Collapsed;

            IdiomaIzquierda.Visibility = Visibility.Visible;
            IdiomaDerecha.Visibility = Visibility.Visible;

        }


        private void Avanza1Izquierda_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                if (Graficos1.Text == "Ventana")
                {
                    Graficos1.Text = "Pantalla Completa";
                }
                else if (Graficos1.Text == "Pantalla Completa")
                {
                    Graficos1.Text = "Ventana Sin Bordes";
                }
                else if (Graficos1.Text == "Ventana Sin Bordes")
                {
                    Graficos1.Text = "Ventana";
                }
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido1.Text);
                if (s > 0) s -= 5;
                Sonido1.Text = s.ToString();
            }

        }

        private void Avanza2Izquierda_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos2.Text);
                if (s > 0) s -= 5;
                Graficos2.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido2.Text);
                if (s > 0) s -= 5;
                Sonido2.Text = s.ToString();
            }

        }
        private void Avanza3Izquierda_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos3.Text);
                if (s > 0) s -= 5;
                Graficos3.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido3.Text);
                if (s > 0) s -= 5;
                Sonido3.Text = s.ToString();
            }
            else if (IdiomaDerecha.Visibility == Visibility.Visible)
            {
                if (Idioma2.Text == "Español")
                    Idioma2.Text = "Ingles";
                else if (Idioma2.Text == "Ingles")
                    Idioma2.Text = "Frances";
                else if (Idioma2.Text == "Frances")
                    Idioma2.Text = "Español";

            }

        }
        private void Avanza4Izquierda_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos4.Text);
                if (s > 0) s -= 5;
                Graficos4.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido4.Text);
                if (s > 0) s -= 5;
                Sonido4.Text = s.ToString();
            }

        }

        private void Avanza1Derecha_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                if (Graficos1.Text == "Ventana")
                {
                    Graficos1.Text = "Ventana Sin Bordes";
                }
                else if (Graficos1.Text == "Ventana Sin Bordes")
                {
                    Graficos1.Text = "Pantalla Completa";
                }
                else if (Graficos1.Text == "Pantalla Completa")
                {
                    Graficos1.Text = "Ventana";
                }
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido1.Text);
                if (s < 100) s += 5;
                Sonido1.Text = s.ToString();
            }

        }

        private void Avanza2Derecha_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos2.Text);
                if (s <100) s += 5;
                Graficos2.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido2.Text);
                if (s < 100) s += 5;
                Sonido2.Text = s.ToString();
            }

        }

        private void Avanza3Derecha_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos3.Text);
                if (s < 100) s += 5;
                Graficos3.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido3.Text);
                if (s < 100) s += 5;
                Sonido3.Text = s.ToString();
            }
            else if (IdiomaDerecha.Visibility == Visibility.Visible)
            {
                if (Idioma2.Text == "Español")
                {
                    Idioma2.Text = "Frances";
                    Idioma1.Text = "Frances";
                }
                else if (Idioma2.Text == "Frances")
                {
                    Idioma2.Text = "Ingles";
                    Idioma1.Text = "Ingles";
                }
                else if (Idioma2.Text == "Ingles")
                {
                    Idioma2.Text = "Español";
                    Idioma1.Text = "Español";
                }

            }
        }

        private void Avanza4Derecha_(object sender, RoutedEventArgs e)
        {
            if (GraficosDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Graficos4.Text);
                if (s < 100) s += 5;
                Graficos4.Text = s.ToString();
            }
            else if (SonidoDerecha.Visibility == Visibility.Visible)
            {
                int s = int.Parse(Sonido4.Text);
                if (s < 100) s += 5;
                Sonido4.Text = s.ToString();
            }
        }


        private void GraficosKeyDown(object sender, RoutedEventArgs e)
        {
            if (IdiomaIzquierda.Visibility == Visibility.Visible)
            {
                IdiomaIzquierda.Visibility = Visibility.Collapsed;
                IdiomaDerecha.Visibility = Visibility.Collapsed;

                Avanza1Derecha.Visibility = Visibility.Visible;
                Avanza4Derecha.Visibility = Visibility.Visible;
                Avanza1Izquierda.Visibility = Visibility.Visible;
                Avanza4Izquierda.Visibility = Visibility.Visible;

                Graficos_.Foreground = Idioma_.Foreground;
                Idioma_.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (SonidoIzquierda.Visibility == Visibility.Visible)
            {
                SonidoIzquierda.Visibility = Visibility.Collapsed;
                SonidoDerecha.Visibility = Visibility.Collapsed;

                Graficos_.Foreground = Sonido_.Foreground;
                Sonido_.Foreground = new SolidColorBrush(Colors.Black);
            }

            GraficosIzquierda.Visibility = Visibility.Visible;
            GraficosDerecha.Visibility = Visibility.Visible;

        }
    }
}
