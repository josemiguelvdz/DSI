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
        private int diamonds;
        public Hub()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is int)
            {
                diamonds = (int)e.Parameter;
            }
            base.OnNavigatedTo(e);
        }

        private void ReturnToMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Página1));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Graficos));
        }

        private void Level1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Nivel1),diamonds);
        }

        private void Level2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Nivel1), diamonds);
        }

        private void Level3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Nivel1), diamonds);
        }

        private void Level4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Nivel1), diamonds);
        }

        private void RobotTeam_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RobotTeam));
        }

 

        private void n1Img_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {
            n1Img.Width +=25;
            n1Img.Height += 25;
        }

        private void n1Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            n1Img.Width -=25;
            n1Img.Height -=25;
        }

        private void n3Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            n3Img.Width += 25;
            n3Img.Height += 25;
        }

        private void n2Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            n2Img.Width += 25;
            n2Img.Height += 25;
        }

        private void n2Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            n2Img.Width -= 25;
            n2Img.Height -= 25;
        }

        private void n3Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            n3Img.Width -= 25;
            n3Img.Height -= 25;

        }

        private void n4Img_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            n4Img.Width += 25;
            n4Img.Height += 25;
        }

        private void n4Img_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            n4Img.Width -= 25;
            n4Img.Height -= 25;
        }
    }
}
