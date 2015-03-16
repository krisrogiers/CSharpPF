using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class Personenwagen:Voertuig, IVervuiler
    {
        public Personenwagen()
            : base()
        {
            AantalDeuren = 4;
            AantalPassagiers = 5;
        }

        public Personenwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, int aantalDeuren, int aantalPassagiers)
            : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }

        private int aantalDeurenValue;

        public int AantalDeuren
        {
            get { return aantalDeurenValue; }
            set { 
                if (value > 0)
                aantalDeurenValue = value; }
        }

        private int aantalPassagiersValue;

        public int AantalPassagiers
        {
            get { return aantalPassagiersValue; }
            set {
                if (value > 0)
                aantalPassagiersValue = value; }
        }

        public override void Afbeelden()
        {
            Console.WriteLine("Personenwagen"); 
            base.Afbeelden(); 
            Console.WriteLine("Aantal Deuren: {0}", AantalDeuren); 
            Console.WriteLine("Aantal passagiers: {0}", AantalPassagiers);
        }

        public override double GetKyotoScore()
        { 
            double kyotoScore = 0.0; 
            if (AantalPassagiers != 0) 
            { 
                kyotoScore = (GemiddeldVerbruik * Pk) / AantalPassagiers; 
            } 
            return kyotoScore; 
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore()*5;
        }
        
    }
}
