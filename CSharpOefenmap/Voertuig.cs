using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOefenmap
{
    public abstract class Voertuig: IPrivaat, IMilieu
    {
        //constructors

        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            this.Polishouder = polishouder;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemiddeldVerbruik;
            this.Nummerplaat = nummerplaat;
        }
        public Voertuig() : this("onbepaald",0m,0,0f,"onbepaald")
        {            
        }

        //properties
        private string polishouderValue;

        public string Polishouder
        {
            get { return polishouderValue; }
            set { polishouderValue = value; }
        }

        private decimal kostprijsValue;

        public decimal Kostprijs
        {
            get { return kostprijsValue; }
            set 
            {
                if (value > 0) 
                { kostprijsValue = value; }                
            }
        }

        private int pkValue;

        public int Pk
        {
            get { return pkValue; }
            set 
            {
                if (value>0)
                {pkValue = value;} 
            }
        }

        private float gemiddeldVerbruikValue;

        public float GemiddeldVerbruik
        {
            get { return gemiddeldVerbruikValue; }
            set 
            {
                if (value > 0)
                { 
                    gemiddeldVerbruikValue = value; 
                } 
            }
        }

        private string nummerplaatValue;

        public string Nummerplaat
        {
            get { return nummerplaatValue; }
            set { nummerplaatValue = value; }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Polishouder: {0}", Polishouder);
            Console.WriteLine("Kostprijs: {0}", Kostprijs);
            Console.WriteLine("Aantal pk: {0}", Pk);
            Console.WriteLine("Gemiddeld verbruik: {0}", GemiddeldVerbruik);
            Console.WriteLine("Nummerplaat: {0}", Nummerplaat);
        }

        public abstract double GetKyotoScore();



        public string GeefPrivateData()
        {
            return string.Format("Polishouder: {0} - Nummerplaat: {1}",Polishouder, Nummerplaat);
        }


        public string GeefMilieuData()
        {
            return string.Format("PK:{0} - Kostprijs: {1} - Gemiddeld verbruik: {2}", Pk, Kostprijs, GemiddeldVerbruik);
        }


    }
}
