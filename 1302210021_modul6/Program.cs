
using System;

namespace _1302210021_modul6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sayaTubeUser saya = new sayaTubeUser("Syahran");

            sayaTubeVidio vidio1 = new sayaTubeVidio("Review Film A " + saya.username);
            sayaTubeVidio vidio2 = new sayaTubeVidio("Review Film B " + saya.username);
            sayaTubeVidio vidio3 = new sayaTubeVidio("Review Film C " + saya.username);
            sayaTubeVidio vidio4 = new sayaTubeVidio("Review Film D " + saya.username);
            sayaTubeVidio vidio5 = new sayaTubeVidio("Review Film E " + saya.username);
            sayaTubeVidio vidio6 = new sayaTubeVidio("Review Film F " + saya.username);
            sayaTubeVidio vidio7 = new sayaTubeVidio("Review Film G " + saya.username);
            sayaTubeVidio vidio8 = new sayaTubeVidio("Review Film H " + saya.username);
            sayaTubeVidio vidio9 = new sayaTubeVidio("Review Film I " + saya.username);
            sayaTubeVidio vidio10 = new sayaTubeVidio("Review Film J " + saya.username);

            saya.addVidio(vidio1);
            saya.addVidio(vidio2);
            saya.addVidio(vidio3);
            saya.addVidio(vidio4);
            saya.addVidio(vidio5);
            saya.addVidio(vidio6);
            saya.addVidio(vidio7);
            saya.addVidio(vidio8);
            saya.addVidio(vidio9);
            saya.addVidio(vidio10);

            for(int i = 0; i < saya.getVidioList().Count; i++)
            {
                saya.getVidioList()[i].increasePlayCount(1000);
                saya.getVidioList()[i].printVidioDetail();

            }

            saya.printAllVidioPlaycount();
        }
    }
}