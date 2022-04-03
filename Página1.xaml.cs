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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace P3JoseMiguelVillacanas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public interface INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
    }

    public sealed partial class Página1 : Page, INotifyPropertyChanged
    {
        private DispatcherTimer _timer;

        public Página1()
        {
            this.InitializeComponent();

            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            _timer.Tick += (sender, o) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));

            _timer.Start();

        }

        public string CurrentTime => DateTime.Now.ToLongTimeString();
        public event PropertyChangedEventHandler PropertyChanged;


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }
    }
}
