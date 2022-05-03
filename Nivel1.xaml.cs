using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 

    public sealed partial class Nivel1 : Page
    {

        public Nivel1()
        {
            this.InitializeComponent();
        }

        private void Pause(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pause));
        }

        private void image_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            StackPanel O = sender as StackPanel;

            string id = O.Name.ToString();

            args.Data.SetText(id);

            args.Data.RequestedOperation = DataPackageOperation.Move;
        }

        private async void Image_Drop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            StackPanel s = sender as StackPanel;
            Image i = (FindName(id) as StackPanel).Children[0] as Image;
            (s.Children[0] as Image).Source = i.Source;
        }
        private void Image_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
        }

    }
}
