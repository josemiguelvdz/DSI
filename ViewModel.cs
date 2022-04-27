using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace P3JoseMiguelVillacanas
{
    public class RobotVM : Robot
    {
        public Image Img;
        public ContentControl CCImg;
        public int Zoom;
        public RobotVM(Robot robot)
            {
            Id = robot.Id;
            Nombre = robot.Nombre;
            Imagen = robot.Imagen;
            Explicacion = robot.Explicacion;
            Estado = robot.Estado;
            X = robot.X;
            Y = robot.Y;
            RX = robot.RX;
            RY = robot.RY;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + robot.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
            Transformacion = new CompositeTransform();
            //CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;//.Collapsed;
            //Mapa.Children.Add(CCImg);
            //Mapa.Children.Last().SetValue(Canvas.LeftProperty, X - 25);
            //Mapa.Children.Last().SetValue(Canvas.TopProperty, Y - 25);
        }
    }


   
}
