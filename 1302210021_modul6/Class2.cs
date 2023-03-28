using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1302210021_modul6
{
    internal class sayaTubeVidio
    {
        private int id;
        private string title;
        private int playCount;


        public sayaTubeVidio(string title)
        {
            Contract.Requires(title.Length <=  200);
            Contract.Assert(title != null);

            this.title = title;
        }

        public void increasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }

        public  int getplayCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void printVidioDetail()
        {
            Console.WriteLine("User "+ id +" Vidio "+ title +" playcount "+ playCount);
            
        }
    }
}
