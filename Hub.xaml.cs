using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Hub : Page
    {
        Atributos atributos;
        public Hub()
        {
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            atributos = (Atributos)e.Parameter;
            if (atributos.getNivel(3))
            {
                Level4Blocked.Visibility = Visibility.Collapsed;
                Level4.Visibility = Visibility.Visible;
            }
            else if (atributos.getNivel(2))
            {
                Level3Blocked.Visibility = Visibility.Collapsed;
                Level3.Visibility = Visibility.Visible;
            }
            else if (atributos.getNivel(1))
            {
                Level2Blocked.Visibility = Visibility.Collapsed;
                Level2.Visibility = Visibility.Visible;
            }
            base.OnNavigatedTo(e);
        }

        private void ReturnToMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Página1),atributos);
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes),atributos);
        }

        private void Level1_Click(object sender, RoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel1Block")
            {
                atributos.setNivelActual(0);
                Frame.Navigate(typeof(Nivel1), atributos);
            }
        }

        private void Level2_Click(object sender, RoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel2Block.png" && (sender as Image).Visibility==Visibility.Visible)
            {
                atributos.setNivelActual(1);
                Frame.Navigate(typeof(Nivel1), atributos);
            }
        }

        private void Level3_Click(object sender, RoutedEventArgs e)
        {
            atributos.setNivelActual(2);
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel3Block.png")
            {
                Frame.Navigate(typeof(Nivel1), atributos);
            }
        }

        private void Level4_Click(object sender, RoutedEventArgs e)
        {
            atributos.setNivelActual(3);
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel4Block.png")
            {
                Frame.Navigate(typeof(Nivel1), atributos);
            }
        }

        private void RobotTeam_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RobotTeam),atributos);
        }

 

        private void n1Img_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {
            Level1.Width +=25;
            Level1.Height += 25;
        }

        private void n1Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Level1.Width -= 25;
            Level1.Height -= 25;
        }

        private void n3Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel3Block")
            {
                Level3.Width += 25;
                Level3.Height += 25;
            }
        }

        private void n2Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel2Block")
            {
                Level2.Width += 25;
                Level2.Height += 25;
            }
        }

        private void n2Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel2Block")
            {
                Level2.Width -= 25;
                Level2.Height -= 25;
            }
        }

        private void n3Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel2Block")
            {
                Level3.Width -= 25;
                Level3.Height -= 25;
            }
        }

        private void n4Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel4Block")
            {
                Level4.Width += 25;
                Level4.Height += 25;
            }
        }

        private void n4Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if ((((sender as Image).Source) as BitmapImage).UriSource.AbsolutePath != "/Assets/nivel4Block")
            {
                Level4.Width -= 25;
                Level4.Height -= 25;
            }
        }
    }
}
