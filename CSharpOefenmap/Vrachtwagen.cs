using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class Vrachtwagen: Voertuig, IVervuiler
    {
        public double GeefVervuiling() 
        {
            return GetKyotoScore() * 20;
        }
        public Vrachtwagen()
            : base()
        {
            MaximumLading = 10000f;
        }

        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik,string nummerplaat, float maximumLading) 
        : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            MaximumLading = maximumLading;
        }

        private float maximuLadingValue;

        public float MaximumLading
        {
            get { return maximuLadingValue; }
            set { 
                if (value>=0f)
                maximuLadingValue = value; }
        }

        public void Afbeelden()
        {
            Console.WriteLine("Vrachtwagen");
            base.Afbeelden();
            Console.WriteLine("Maximum lading: {0}", MaximumLading);

        }

        public override double GetKyotoScore()
        {
            double kyotoScore = 0.0; 
            if (MaximumLading != 0) 
            { 
                kyotoScore = (GemiddeldVerbruik * Pk) / (MaximumLading / 1000.0); 
            } 
            return kyotoScore;
        }     



    }
}
