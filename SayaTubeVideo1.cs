using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(0, 100000);
            this.playCount = 0;

            Debug.Assert(title != null, "title tidak boleh kosong");
            Debug.Assert(title.Length < 100, "title kepanjangan");

            string test;

            try
            {
                test = checked(title);
                this.title = title;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void IncreasePlayCount(int data)
        {
            Debug.Assert(this.playCount <= int.MaxValue);
            Debug.Assert(data <= 10000000, "Input tidak boleh lebih dari 10 juta");


            int test;
            try
            {
                test = checked(this.playCount + data);
                this.playCount += data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                this.playCount = this.playCount;
            }

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id : " + this.id);
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount + "\n");
        }
    }
}