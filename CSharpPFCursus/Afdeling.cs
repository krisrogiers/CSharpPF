using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firma.Personeel
{
    public class Afdeling
    {

        private const int Verdiepingen = 10;
        public Afdeling(string naam, int verdieping)
        {
            Naam = naam;
            Verdieping = verdieping;
            
        }
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }

        private int verdiepingsValue;

        public int Verdieping
        {
            get { return verdiepingsValue; }
            set 
            { 
                if(value>=0 && value <= Verdiepingen)
                verdiepingsValue = value; 
            }
        }

        public override string ToString()
        {
            return String.Format("Afdeling: {0} op verdieping {1} ", Naam, Verdieping);
        }       
        
        
        
    }
}
