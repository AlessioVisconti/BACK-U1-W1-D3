using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BACK_U1_W1_D3.Class
{
    public class ContoCorrente
    {
        //il conto ha: Nome, cognome, numero carta, secret number, iban, scadanza, saldo
        //metodo per caricare il conto
        //metodo per prelevare

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumDocumento { get; set; }
        public string NumeroConto { get; set; }
        public int NumeroCarta { get; set; }
        public string Iban { get; set; }
        private string Pin { get; set; }
        private int CVV { get; set; }
        
        public string DataFine { get; set; }
        public int Saldo { get; set; }

  

        //public ContoCorrente(string nome, string cognome, string numDocumento, string numeroConto, int numeroCarta, string iban, string pin, int cvv, string dataFine="08/24", int saldo = 0)
        //{
        //    this.Nome = nome;
        //    this.Cognome = cognome;
        //    this.NumDocumento = numDocumento;
        //    this.NumeroConto = numeroConto;
        //    this.NumeroCarta = numeroCarta;
        //    this.Iban = iban;
        //    this.Pin = pin;
        //    this.CVV = cvv;
        //    this.DataFine = dataFine;
        //    this.Saldo = saldo;
            
        //}
        public static string[] documenti = { "AX1111", "AX2222", "AX3333" };
        public void ApriConto() {
            Console.WriteLine("Stiamo aprendo il conto");
            Console.WriteLine("Inserisci il tuo numero di documento: ");
            string numDocumento = Console.ReadLine();
            foreach(string doc in documenti)
            {
                if(doc== numDocumento)
                {
                    Console.WriteLine("Esiste già un conto");
                    return;
                }
            }
            
            Console.WriteLine("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il Pin: ");
            string pin = Console.ReadLine();
            Random rnd = new Random();
            string numeroConto = "";
            string numeroCartaProvvisorio = "";
            string numeroCartaProvvisorioCVV = "";
            string iban = "IT00";
            
            for (int i = 0; i < 16; i++)
            {
                int rndNumero = rnd.Next(0, 10);
                numeroConto += rndNumero.ToString();

            }

            for (int i = 0; i < 5; i++)
            {
            int rndNumero = rnd.Next(0, 10);
                numeroCartaProvvisorio += rndNumero.ToString();
            
            }
            int numeroCarta = int.Parse(numeroCartaProvvisorio);
           
            for (int i = 0; i < 16; i++)
            {
                int rndNumero = rnd.Next(0, 10);
                iban += rndNumero.ToString();

            }
            for (int i = 0; i < 3; i++)
            {
                int rndNumero = rnd.Next(0, 10);
                numeroCartaProvvisorioCVV += rndNumero.ToString();

            }
            int cvv = int.Parse(numeroCartaProvvisorioCVV);
            Console.WriteLine("E' richiesto un deposito di 1000€ per aprire il conto vuole procedere?");
            Console.WriteLine("1: si");
            Console.WriteLine("2: no");
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                   Saldo= 1000;
                    break;
                case "2":
                    Console.WriteLine("Apertura del conto non riuscita");
                    break;
            }
          
            Console.WriteLine("Il tuo conto è stato aperto con successo, ecco un riepilogo dei tuoi dati");
            Console.WriteLine($"Numero conto: {numeroConto}");
            Console.WriteLine($"Iban: {iban}");
            Console.WriteLine($"Saldo iniziale: {Saldo}");
            


           
            
        }
        public void Prelievo()
        {
            Console.WriteLine("Quanto vuoi prelevare?");
            string prelievo = Console.ReadLine();
            int prelievoParsato = int.Parse(prelievo);
            if (Saldo < prelievoParsato)
            {
                Console.WriteLine("Credito insufficiente");
            }
            else
            {
                int saldo = -prelievoParsato;
                Console.WriteLine($"il nuovo saldo è: {saldo}");
            }
        }
        public void Deposita()
        {
            Console.WriteLine("Quanto vuoi depositare?");
            string deposito = Console.ReadLine();
            int depositoParsato = int.Parse(deposito);
            int saldo=+ depositoParsato;
            Console.WriteLine($"il nuovo saldo è: {saldo}");
        }
       
    }
}
