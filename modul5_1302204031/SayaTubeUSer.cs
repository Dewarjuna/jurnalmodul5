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
            uploadedVideo.Add(data);
        }


        public void printAllvideoplayCount()
        {
            Console.WriteLine("username:" + Username);

            for(int i = 0; i < uploadedVideo.Count; i++)
            {
                
                Console.WriteLine("video " + (i + 1) + ": " + uploadedVideo[i].GetTitle());            }
            
        }
    }
}
