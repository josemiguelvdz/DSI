using System;
using System.Collections.Generic;
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
    public sealed partial class RobotTeam : Page
    {
        Atributos atributos;
        public RobotTeam()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            atributos = (Atributos)e.Parameter;
            int suma = 0;
            suma += int.Parse( ValorRobotEnUso1.Text);
            suma += int.Parse(ValorRobotEnUso2.Text);
            suma += int.Parse(ValorRobotEnUso3.Text);
            suma += int.Parse(ValorRobotEnUso4.Text);
            suma += int.Parse(ValorRobotEnUso5.Text);
            suma += int.Parse(ValorRobotEnUso6.Text);
            Media.Text = (suma / 6).ToString();
            base.OnNavigatedTo(e);
        }

        private void ReturnToMenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hub),atributos);
        }

        private void image_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            Image O = sender as Image;

            string id = O.Name.ToString();

            args.Data.SetText(id);

            args.Data.RequestedOperation = DataPackageOperation.Move;
        }

        private async void Image_Drop(object sender, DragEventArgs e)
        {
            Image s = sender as Image;

            Image i = FindName(await e.DataView.GetTextAsync()) as Image;
            StackPanel s1 = i.Parent as StackPanel;
            Image iAux =new Image();
            string sAux = ((s1 as StackPanel).Children[2] as TextBlock).Text.ToString();
            iAux.Source = i.Source;
            (s1.Children[2] as TextBlock).Text = ((s.Parent as StackPanel).Children[2] as TextBlock).Text;
            i.Source = s.Source;
            s.Source = iAux.Source;
            ((s.Parent as StackPanel).Children[2] as TextBlock).Text = sAux;


            int suma = 0;
            suma += int.Parse(ValorRobotEnUso1.Text);
            suma += int.Parse(ValorRobotEnUso2.Text);
            suma += int.Parse(ValorRobotEnUso3.Text);
            suma += int.Parse(ValorRobotEnUso4.Text);
            suma += int.Parse(ValorRobotEnUso5.Text);
            suma += int.Parse(ValorRobotEnUso6.Text);
            Media.Text = (suma/6).ToString();
        }

        private void Image_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
        }
    }
}
