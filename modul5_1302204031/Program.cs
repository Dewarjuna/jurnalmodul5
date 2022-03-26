using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204031
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                SayaTubeUSer user = new SayaTubeUSer("Dewa");
                SayaTubeVideo video = new SayaTubeVideo("Review Film Interstellar oleh Dewa");
                video.IncreaseplayCount(20);
                user.addVideo(video);
                SayaTubeVideo video2 = new SayaTubeVideo("Review Film The Martian oleh Dewa");
                user.addVideo(video2);
                SayaTubeVideo video3 = new SayaTubeVideo("Review Film The Wandering Earth oleh Dewa");
                user.addVideo(video3);
                SayaTubeVideo video4 = new SayaTubeVideo("Review Film Arknights oleh Dewa");
                user.addVideo(video4);
                SayaTubeVideo video5 = new SayaTubeVideo("Review Film Spiderman oleh Dewa");
                user.addVideo(video5);
                SayaTubeVideo video6 = new SayaTubeVideo("Review Film The Avengers oleh Dewa");
                user.addVideo(video6);
                SayaTubeVideo video7 = new SayaTubeVideo("Review Film Star Trek oleh Dewa");
                user.addVideo(video7);
                SayaTubeVideo video8 = new SayaTubeVideo("Review Film Captain America oleh Dewa");
                user.addVideo(video8);
                SayaTubeVideo video9 = new SayaTubeVideo("Review Film Your Name oleh Dewa");
                user.addVideo(video9);
                SayaTubeVideo video10 = new SayaTubeVideo("Review Film 5 cm oleh Dewa");
                user.addVideo(video10);
                user.printAllvideoplayCount();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}