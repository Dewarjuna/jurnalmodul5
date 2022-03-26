using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204031
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;


        public SayaTubeVideo(string v)
        {
            if (v.Length > 200 && v == null)
                throw new Exception("Judul kelebihan");
            title = v;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;
        }

        public void IncreaseplayCount(int angka)
            
        {
            if (angka > 25000000 && angka < 0)
                throw new Exception("play count kelebihan");
            playCount = checked(playCount + angka);
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }
    }
}
