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
        private int diamonds=500;
        private int energia = 100;
        List<object> robotsEnergia = new List<object>();
        int aux = 0;
        DispatcherTimer energiaTimer;

        public Nivel1()
        {
            this.InitializeComponent();
            TimerSetup();
        }

        public void TimerSetup()
        {
            energiaTimer = new DispatcherTimer();
            energiaTimer.Tick += TimerSetup_Tick;// dispatcherTimer_Tick;
            energiaTimer.Interval = new TimeSpan(100000); //100000*10^-7s=1cs;
            energiaTimer.Start();
        }

        void TimerSetup_Tick(object sender, object e)
        { //Función de respuesta al Timer cada 0.01s
            subeProgressBar();
            EnergiaTotal.Text = energia.ToString();
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
            StackPanel i = FindName(id) as StackPanel;


            if (i.Children[1] as ProgressBar != null)
            {
                if (s.Children[0] as Image != null && ((s.Children[0] as Image).Source as BitmapImage).UriSource.AbsolutePath == ((baldosa1.Source) as BitmapImage).UriSource.AbsolutePath && energia>=50)
                {
                    (s.Children[0] as Image).Source = (i.Children[0] as Image).Source;
                    ProgressBar p = new ProgressBar();
                    p.Value = 0;
                    p.Maximum = 100;
                    p.Foreground = (i.Children[1] as ProgressBar).Foreground;
                    Image image = s.Children[0] as Image;
                    s.Children[0] = p;
                    s.Children.Add(image);
                    robotsEnergia.Add(s);
                    aux++;
                    energia -= 50;
                }
            }
            else if (s.Children[0] as Image != null && ((s.Children[0] as Image).Source as BitmapImage).UriSource.AbsolutePath == ((baldosa1.Source) as BitmapImage).UriSource.AbsolutePath)
            {
                if (((i.Children[0] as Image).Source as BitmapImage).UriSource.AbsolutePath == "/Assets/Robot3.png" && energia>=100)
                {
                    (s.Children[0] as Image).Source = (i.Children[0] as Image).Source;
                    energia -= 100;
                }
            }
            else if(((i.Children[0] as Image).Source as BitmapImage).UriSource.AbsolutePath == "/Assets/pala.png")
            {
                if (s.Children[0] as ProgressBar != null)
                {
                    Image image = s.Children[1] as Image;
                    robotsEnergia.Remove(s);
                    s.Children.Remove(s.Children[1]);
                    s.Children[0] = image;
                    (s.Children[0] as Image).Source = baldosa1.Source;
                }
            }
        }

        private void Image_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
        }
        private void subeProgressBar()
        {
            if(robotsEnergia!=null)
            for(int i=0;i< robotsEnergia.Count; i++) {
                if (robotsEnergia[i] != null)
                {
                    if((robotsEnergia[i] as StackPanel).Children[0] as ProgressBar!=null) ((robotsEnergia[i] as StackPanel).Children[0] as ProgressBar).Value += 0.3f;
                    if((robotsEnergia[i] as StackPanel).Children[0] as ProgressBar != null && ((robotsEnergia[i] as StackPanel).Children[0] as ProgressBar).Value == 100)
                    {
                        ((robotsEnergia[i] as StackPanel).Children[0] as ProgressBar).Value = 0;
                        energia += 25;
                    }

                    
                }

            }
        }
    }
}
