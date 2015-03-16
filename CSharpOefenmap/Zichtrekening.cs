using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class ZichtRekening:Rekening
    {
        private decimal maxKredietValue;

        public decimal MaxKrediet
        {
            get { return maxKredietValue; }
            set 
            {
                if (value > 0m)
                    throw new Exception("De waarde van MaxKrediet mag niet positief zijn");
                maxKredietValue = value; 
            }

        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Max.krediet: {0}", MaxKrediet);
        }

        public ZichtRekening(ulong nummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }
    }
}
