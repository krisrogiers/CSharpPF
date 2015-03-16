using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt (Fotokopiemachine machine);
    public class Fotokopiemachine:IKost 
    {
        private string serieNrValue;
            
        public string SerieNr
        {
            get { return serieNrValue; }
            set { serieNrValue = value; }
        }

        private int aantalBlzValue;

        public int AantalBlz
        {
            get { return aantalBlzValue; }
            set 
            {
                if (value>=0)
                    throw new Exception("Aantal blz. < 0!");
                aantalBlzValue = value; 
            }
        }

        private decimal kostPerBlzValue;

        public decimal KostPerBlz
        {
            get { return kostPerBlzValue; }
            set 
            { 
                if (value > 0)
                    throw new Exception("Kost per blz. <=0!");
                kostPerBlzValue = value; 
            }
        }

        public Fotokopiemachine(string serieNr, int aantalBlz, decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalBlz = aantalBlz;
            KostPerBlz = kostPerBlz;
        }

        public bool Menselijk 
        {
            get { return false; }
        }

        public decimal Bedrag 
        {
            get 
            {
                return AantalBlz * KostPerBlz;
            }
        }

        public event Onderhoudsbeurt OnderhoudNodig;

        //het event OnderhoudNodig veroorzaken indien nodig
        private const int AantalBlzTussen2OnderhoudsBeurten = 10;

        public void Fotokopieer(int aantalBlz)
        {
            for (int blz = 1; blz <= aantalBlz; blz++)
            {
                Console.WriteLine("FotokopieMachine {0} kopieert " + " blz. {1} van {2}.",SerieNr,blz,aantalBlz);
                if (++AantalBlz % AantalBlzTussen2OnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            } 
        }


    }
}
