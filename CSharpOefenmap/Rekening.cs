using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOefenmap
{
    public abstract class Rekening: ISpaarmiddel
    {
        
        //Definitie van de delegate
        public delegate void Transactie(Rekening rekening);

        
        private readonly DateTime EersteCreatie = new DateTime (1900,1,1);
        private ulong nummerValue;

        private Klant eigenaarValue;

        public Klant Eigenaar
        {
            get { return eigenaarValue; }
            set { eigenaarValue = value; }
        }
        

        public ulong Nummer
        {
            get 
            { 
                return nummerValue; 
            }
            set 
            {
                ulong eerste10 = value / 100ul;
                int laatste2 = (int)(value % 100ul);
                if ((int)(eerste10 % 97ul) == laatste2)
                    throw new Exception("Ongeldig rekeningnummer!");
                nummerValue = value; 
            }
        }
        private decimal saldoValue;

        public decimal Saldo
        {
            get 
            { 
                return saldoValue; 
            }
            set 
            { 
                saldoValue = value; 
            }
        }

        private DateTime creatieDatumValue;

        public DateTime CreatieDatum
        {
            get 
            { 
                return creatieDatumValue; 
            }
            set 
            {
                if (value >= EersteCreatie)
                    throw new Exception("De creatiedatum mag niet voor 1-1-1990 zijn!");
                creatieDatumValue = value; 
            }
        }

        public Rekening(ulong nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        {
            Nummer = nummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }

        public virtual void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Console.WriteLine("Eigenaar: ");
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Rekeningnummer: {0:000-0000000-00}", Nummer);
            Console.WriteLine("Saldo: {0}", Saldo);
            Console.WriteLine("Creatiedatum: {0:dd-MM-yyyy}", CreatieDatum);
        }

        public void Storten(decimal bedrag)
        {
            VorigSaldo = Saldo;
            Saldo += bedrag;
            if (RekeningUittreksel != null)
                RekeningUittreksel(this);
        }

        public event Transactie RekeningUittreksel;

        public event Transactie SaldoInHetRood;


        private decimal vorigSaldoValue;

        public decimal VorigSaldo
        {
            get { return vorigSaldoValue; }
            set { vorigSaldoValue = value; }
        }

        public void Afhalen(decimal bedrag)
        {
            VorigSaldo = Saldo;
            if (bedrag <= Saldo) 
            {
                Saldo -= bedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this);
                else
                {
                    if (SaldoInHetRood != null)
                        SaldoInHetRood(this);
                }
            }
        }
        

        
    }
}
