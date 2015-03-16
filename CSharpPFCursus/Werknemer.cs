using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public abstract class Werknemer:IKost
    {              

        private WerkRegime regimeValue;

        public WerkRegime Regime
        {
            get { return regimeValue; }
            set { regimeValue = value; }
        }
        
        private string naamValue;
        private DateTime inDienstValue;
        private Geslacht geslachtValue;

        /*public Werknemer(): this("Onbekend",DateTime.Today,Geslacht.Man)
        {

        }
        */

        static Werknemer()
        {
            Personeelsfeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelsfeest = Personeelsfeest.AddDays(1);
        }

        private static DateTime personeelsfeestValue;
            
        public static DateTime Personeelsfeest
        {
            get { return personeelsfeestValue; }
            set { personeelsfeestValue = value; }
        }
        

        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }
        /*public Werknemer()
        {
            this.Naam = "Onbekend";
            this.InDienst = DateTime.Today;
        }
         */
        public virtual void Afbeelden() 
        {
            Console.WriteLine("Naam: {0}", Naam);
            Console.WriteLine("Geslacht: {0}", Geslacht);
            Console.WriteLine("In dienst: {0}", InDienst);
            Console.WriteLine("Personeelsfeest: {0}", Personeelsfeest);
            if (Afdeling != null)
                Console.WriteLine(Afdeling);
        }
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public DateTime InDienst
        {
            get
            {
                return inDienstValue;
            }
            set
            {
                inDienstValue = value;
            }
        }

        public Geslacht Geslacht
        {
            get
            {
                return geslachtValue;
            }
            set
            {
                geslachtValue = value;
            }
        }

        private decimal salarisValue;

        public decimal Salaris
        {
            get 
            { 
                return salarisValue;
            }
            private set 
            {
                if (value >=0m)
                    salarisValue = value; 
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return inDienstValue.Month == DateTime.Today.Month && inDienstValue.Day == DateTime.Today.Day;
            }

        }

        public override string ToString()
        {
            return Naam + ' ' + Geslacht;
        }

        public override bool Equals(object obj)
        {
            if (obj is Werknemer)
            {
                Werknemer deAndere = (Werknemer)obj;
                return this.Naam == deAndere.Naam;
            }
            else
                return false;                  
        }

        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }

        public abstract decimal Premie
        {
            get;
        }


        private Afdeling afdelingValue;
        public Afdeling Afdeling
        {
            get
            {
                return afdelingValue;
            }
            set
            {
                afdelingValue = value;
            }
        }

        public class WerkRegime
        {
            public enum RegimeType
            {
                Voltijds,
                Viervijfde,
                Halftijds,
            }

            private RegimeType typeValue;

            public RegimeType Type
            {
                get { return typeValue; }
                set { typeValue = value; }
            }

            public int Vakantie 
            {
                get
                {
                    switch (Type)
                    {
                        case RegimeType.Voltijds:
                            return 25;
                        case RegimeType.Viervijfde:
                            return 20;
                        case RegimeType.Halftijds:
                            return 12;
                        default:
                            return 0;
                    }
                }
                
            }
            public WerkRegime(RegimeType type)
            {
                Type = type;
            }

            public override string ToString()
            {
                return Type.ToString();
            }
            
            
        }


        public abstract decimal Bedrag
        {
            get;
        }

        public bool Menselijk
        {
            get 
            {
                return true; 
            }
        }

        public static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Uitgebreide werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
            {
                werknemer.Afbeelden();
            }
        }

        public static void KorteWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Verkorte werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
            {
                Console.WriteLine(werknemer.ToString());
            }
        }
    }

}
