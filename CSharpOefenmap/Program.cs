using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SpaarRekening.Intrest = 3m;
                Klant ik = new Klant("Eddy", "Wally");
                ISpaarmiddel[] spaarmiddelen = new ISpaarmiddel[3];
                spaarmiddelen[0] = new ZichtRekening(747524091936ul, 14.51m,DateTime.Today, -500m, ik);
                spaarmiddelen[1] = new SpaarRekening(737524091952ul, 1000m,DateTime.Today, ik);
                spaarmiddelen[2] = new Kasbon(DateTime.Today, 1000m, 5, 3.5m, ik);
                foreach (ISpaarmiddel spaarmiddel in spaarmiddelen)
                    spaarmiddel.Afbeelden();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }


        }
    }
}

