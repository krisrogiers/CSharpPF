using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class Klant
    {
        private string voornaamValue;

        public string Voornaam
        {
            get { return voornaamValue; }
            set { voornaamValue = value; }
        }

        private string familienaamValue;

        public string Familienaam
        {
            get { return familienaamValue; }
            set { familienaamValue = value; }
        }

        public Klant(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }

        public void Afbeelden()
        {
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Familienaam: {0}", Familienaam);
        }


        
        
    }
}
