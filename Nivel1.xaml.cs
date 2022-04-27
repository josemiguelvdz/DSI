using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
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
        public ObservableCollection<RobotVM> ListaRobots { get; } = new ObservableCollection<RobotVM>();

        public Nivel1()
        {
            this.InitializeComponent();
        }

        private void Pause(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pause));
        }

        private async void Image_DropAsync(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            var number = int.Parse(id);
            //Point PD = e.GetPosition(MiCanvas);
            //MiDron.Source = ListaDrones[number].Img.Source;
            //MiImagen.Source = ListaDrones[number].Img.Source;
            //Point pos = e.GetPosition(mi_mapa);

            //MiDron.Visibility = Visibility.Visible;
            //Texto.Text = ListaDrones[number].Explicacion;
            //Sel = int.Parse(id);

            //ListaRobots[Sel].Transformacion.TranslateX = pos.X;
            //ListaRobots[Sel].Transformacion.TranslateY = pos.Y;
            //MiDronCC.RenderTransform = ListaDrones[Sel].Transformacion;
        }

        private void Image_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void ImageGridView_DragItems(object sender, DragItemsStartingEventArgs e)
        {
            RobotVM d = e.Items[0] as RobotVM;
            string id = d.Id.ToString();
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }
    }
}
