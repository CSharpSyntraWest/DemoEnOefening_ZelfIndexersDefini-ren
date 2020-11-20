using System;
using System.Collections.Generic;

namespace Oefening_Bank_Indexer
{
    class BankRekening
    { 
        public string RekNr { get; private set; }
        public double Saldo { get; set; }
        public BankRekening(string rekNr, double saldo)
        {
            RekNr = rekNr;
            Saldo = saldo;
        }
        public static BankRekening operator +(BankRekening bankrekening1, BankRekening bankrekening2)
        {
            return new BankRekening(bankrekening1.RekNr + "S",  bankrekening1.Saldo + bankrekening2.Saldo );
        }
        public static BankRekening operator -(BankRekening bankrekening1, BankRekening bankrekening2)
        {
            return new BankRekening(bankrekening1.RekNr + "V", bankrekening1.Saldo - bankrekening2.Saldo);
        }
        public override string ToString()
        {
            return $"BankRekNr {RekNr} met Saldo: {Saldo}";
        }
    }
    class Bank
    {
        private Dictionary<string, BankRekening> _bankRekeningen;
        public Bank()
        {
            _bankRekeningen = new Dictionary<string, BankRekening>();
        }
        public void VoegBankRekeningToe(BankRekening rek)
        {
            _bankRekeningen.Add(rek.RekNr,rek);
        }
        public BankRekening this[string rekNr]
        {
            get {
                return _bankRekeningen[rekNr];
            }
            set {
                _bankRekeningen[rekNr] = value;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            BankRekening rekeningMan = new BankRekening("BE123456789", 1000.00);
            BankRekening rekeningVrouw = new BankRekening("BE987654321", 50.00);
            BankRekening gezamelijkeRekening = rekeningMan + rekeningVrouw;
            Console.WriteLine("Gezamelijke rekening: " + gezamelijkeRekening);
            BankRekening verschilRekening = gezamelijkeRekening - rekeningVrouw;
            Console.WriteLine("verschil rekening: " + verschilRekening);
            bank.VoegBankRekeningToe(rekeningMan);
            bank.VoegBankRekeningToe(rekeningVrouw);
            //Console.WriteLine(bank["BE123456789"]);
            //bank["BE987654321"].Saldo += 100.00;
            //Console.WriteLine(bank["BE987654321"]);
        }
    }
}
