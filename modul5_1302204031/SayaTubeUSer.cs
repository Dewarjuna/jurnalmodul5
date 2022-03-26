using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204031
{
    internal class SayaTubeUSer
    {
        int id;
        List<SayaTubeVideo> uploadedVideo;
        string Username;

        public SayaTubeUSer(string profile)
        {
            if (profile.Length > 200 && profile == null)
                throw new Exception("Username kelebihan");
            this.Username = profile;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            uploadedVideo=new List<SayaTubeVideo>();

        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void addVideo(SayaTubeVideo data )
        {
            if (data == null)
                throw new Exception("Video tidak ada");
            if(data.GetPlaycount() > 1000000000)
                throw new Exception("Play count ngelunjak anjir awokwokwokw");
            uploadedVideo.Add(data);
        }


        public void printAllvideoplayCount()
        {
            Console.WriteLine("username:" + Username);

            for(int i = 0; i < 8; i++)
            {
                
                Console.WriteLine("video " + (i + 1) + ": " + uploadedVideo[i].GetTitle());            }
            
        }
    }
}
