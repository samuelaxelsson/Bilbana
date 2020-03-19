using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bilbana
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilposition = 40;
            int counter = 0;
            int vänsterkant = 30;
            int bredd = 20;
            Random random = new Random();
            while (true)
            {
                string väg = "".PadRight(vänsterkant, ' ')+   "#".PadRight(bredd, ' ') + "#".PadRight(80 - vänsterkant - bredd - 3);
                väg = väg.Substring(0, bilposition) + "o" + väg.Substring (bilposition - 1);
                Console.WriteLine(väg);
                counter = counter + 1;
                vänsterkant = vänsterkant + random.Next(-2, 3);
                if (vänsterkant < 0)
                {
                    vänsterkant = 0;
                }
                if (vänsterkant + bredd + 2 > 80)
                {
                    vänsterkant = 80 - bredd - 2;
                }
                Thread.Sleep(100);
            }
            
        }
    }
}
