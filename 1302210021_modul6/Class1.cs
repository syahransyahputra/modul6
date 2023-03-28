using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1302210021_modul6
{
    internal class sayaTubeUser
    {
        private int id;
        private List<sayaTubeVidio> uploadedVidio;
        public string username;

        public sayaTubeUser(string username)
        {
            this.username = username;
            Random IDuser = new Random();
            this.id = IDuser.Next(10000, 999999);
            this.uploadedVidio= new List<sayaTubeVidio>();
        }

         public int getTotalVidioPlayCount()
        {
            int total = 0;
            for(int i = 0; i < this.uploadedVidio.Count; i++)
            {
                int upVid = uploadedVidio[i].getplayCount();
                total += total + upVid;
            }
            return total;
        }

        public void addVidio(sayaTubeVidio vid) 
        {
            //.Requires(vid != null);
            //Contract.Assert(vid.getplayCount() !> 25000000);
            this.uploadedVidio.Add(vid);
        }

        public List<sayaTubeVidio> getVidioList()
        {
            return uploadedVidio;
        }

        public void printAllVidioPlaycount()
        {
            Console.WriteLine("USER: "+ username);
            for(int i = 0; i <uploadedVidio.Count; i++)
            {
                Console.WriteLine("Vidio "+ (i + 1) +": "+ uploadedVidio[i].getTitle());
            }
        }
    }
}
