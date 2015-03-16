using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class Kasbon: ISpaarmiddel
    {
        private readonly DateTime EersteAankoop = new DateTime(1900, 1, 1);
        private DateTime aankoopDatumValue;

        public DateTime Aankoopdatum
        {
            get { return aankoopDatumValue; }
            set 
            {
                if (value < EersteAankoop)
                    throw new Exception("De aankoopdatummag niet voor -1-1990 zijn!");
                aankoopDatumValue = value; 
            }
        }

        private decimal bedragValue;

        public decimal Bedrag
        {
            get { return bedragValue; }
            set
            {
                if (value <= 0)
                    throw new Exception("Het bedrag moet positief zij,!");
                bedragValue = value; 
            }
        }

        private int looptijdValue;

        public int Looptijd
        {
            get { return looptijdValue; }
            set 
            { 
                if (value <= 0)
                    throw new Exception("De looptijd moet positief zijn!");
                looptijdValue = value; }
        }

        private decimal intrestValue;

        public decimal Intrest
        {
            get { return intrestValue; }
            set 
            { 
                if (value<=0m)
                    throw new Exception("Intrest moet positief zijn!");
                intrestValue = value; }
        }

        private Klant eigenaarValue;
                    
        public Klant Eigenaar
        {
            get { return eigenaarValue; }
            set { eigenaarValue = value; }
        }


        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        {
            Aankoopdatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }
        

        public void Afbeelden()
        {
            if (Eigenaar != null) 
            {
                Console.WriteLine("Eigenaar");
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Aankoopdatum: {0:dd-MM-yyyy}", Aankoopdatum);
            Console.WriteLine("Bedrag: {0}", Bedrag);
            Console.WriteLine("Looptijd: {0}", Looptijd);
            Console.WriteLine("Intrest: {0}", Intrest);
        }


    }
}
