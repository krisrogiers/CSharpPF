using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOefenmap
{
    public class BankBediende
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

        public BankBediende(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;

        }

        public override string ToString()
        {
            return "Bankbediende " + Voornaam + ' ' + Familienaam;
        }

        public void RekeningUittrekselTonen(Rekening rekening)
        {
            Console.WriteLine("Datum: {0:dd-MM-yyyy}", DateTime.Today);
            Console.WriteLine("Rekeninguittreksel van " + "rekening: {0:000-0000000-00}", rekening.Nummer);
            Console.WriteLine("Vorig saldo: {0} euro", rekening.VorigSaldo);
            if (rekening.Saldo > rekening.VorigSaldo)
            {
                Console.WriteLine("Storting van {0} euro.", rekening.Saldo - rekening.VorigSaldo);
            }
            else
            {
                Console.WriteLine("Afhaling van {0} euro.", rekening.VorigSaldo - rekening.Saldo);
            }
            Console.WriteLine("Nieuw saldo: {0} euro", rekening.Saldo);
        }

        public void RekeningInHetRoodMelden(Rekening rekening)
        {
            Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend!");
            Console.WriteLine("Maximum af te halen bedrag: {0} euro",rekening.Saldo);
        }
    }
}
