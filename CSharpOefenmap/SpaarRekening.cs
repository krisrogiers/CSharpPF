using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class SpaarRekening: Rekening
    {
        private static decimal intrestValue;

        public static decimal Intrest
        {
            get { return intrestValue; }
            set 
            {
                if (value <= 0m)
                    throw new Exception("Intrest moet positief zijn!");
                intrestValue = value;
            }
        }

        public void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }


        //De parameter Intrest is verwijderd
        public SpaarRekening(ulong nummer, decimal saldo,DateTime creatieDatum, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar)
        {
     
        }
        
    }
}
