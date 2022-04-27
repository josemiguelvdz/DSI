using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace P3JoseMiguelVillacanas
{
    public class Robot
    {
        public enum estados { paraUsar, enTablero };

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        //public Image Img;
        public string Explicacion { get; set; }
        public estados Estado { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int RX;
        public int RY;
        public CompositeTransform Transformacion;


        public Robot() { }
    }
    public class Model
    {
        public static List<Robot> Robots = new List<Robot>()
        {                       
            new Robot()
            {
                Id = 0,
                Nombre = "Robot1",
                Imagen = "Assets\\Robot1.jpg",
                Explicacion = @"Explicación Dron1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 10,
                Y = 10,
                RX =100,
                RY =30,
             },
            new Robot()
            {
                Id = 1,
                Nombre = "Robot2",
                Imagen = "Assets\\Robot2.jpg",
                Explicacion = @"Explicación Dron2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 50,
                Y = 50,
                RX =150,
                RY =50,
             },
            new Robot()
            {
                Id = 2,
                Nombre = "Robot3",
                Imagen = "Assets\\Robot3.png",
                Explicacion = @"Explicación Dron3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 100,
                Y = 100,
                RX =50,
                RY =130,
             },
            new Robot()
            {
                Id = 3,
                Nombre = "Robot4",
                Imagen = "Assets\\Robot1.jpg",
                Explicacion = @"Explicación Dron4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 150,
                Y = 150,
                RX =200,
                RY =80,
             },
            new Robot()
            {
                Id = 4,
                Nombre = "Robot5",
                Imagen = "Assets\\Robot2.jpg",
                Explicacion = @"Explicación Dron5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 200,
                Y = 200,
                RX =100,
                RY =140,
             },
            new Robot()
            {
                Id = 5,
                Nombre = "Robot6",
                Imagen = "Assets\\Robot3.png",
                Explicacion = @"Explicación Dron6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Robot.estados.paraUsar,
                X = 250,
                Y = 250,
                RX =30,
                RY =50,
             },
           

          };

      
        public static IList<Robot> GetAllRobots()
        {
            return Robots;
        }

        public static Robot GetRobotById(int id)
        {
            return Robots[id];
        }
    }
}
