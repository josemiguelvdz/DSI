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
    }
}
