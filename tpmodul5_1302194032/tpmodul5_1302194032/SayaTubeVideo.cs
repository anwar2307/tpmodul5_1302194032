using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302194032
{
    internal class SayaTubeVideo
    {
        static void Main(string[] args)
        {
            TubeVideo a = new TubeVideo("Tutorial Design By Contract – [ANWAR YUSUF]");
            a.PrintVideoDetails();
            a.IncreasePlayCount(1);
            a.PrintVideoDetails();
        }
    }
    public class TubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public TubeVideo(string a)
        {
            Random b = new Random();

            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", b.Next());
            Console.WriteLine();

            for (int ctr = 1; ctr <= 50; ctr++)
            {
                Console.Write("{0,3}    ", b.Next(1000, 10000));
                if (ctr % 10 == 0) Console.WriteLine();
            }

            this.id = b.Next(10000, 100000);
            this.title = a;
            playCount = 0;
            setPlayCount(123);
        }
        public void IncreasePlayCount(int a)
        {
            playCount += a;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
        public void setPlayCount(int a)
        {
            this.playCount = a;
        }
        public string getTitle()
        {
            return this.title;
        }
    }
}

