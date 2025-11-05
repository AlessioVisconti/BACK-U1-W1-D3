/*1) Scrivere una classe ContoCorrente che permetta di archiviare diverse proprietà del conto, 
 * più il relativo saldo. In più permetta di effettuare le seguenti azioni:

-Aprire il conto

- Fare un versamento

- Fare un prelievo

N.B.: L'apertura del conto può essere effettuata solo una volta e 
contestualmente deve necessariame
nte consentire un versamento almeno 1000 euro.*/

using BACK_U1_W1_D3.Class;
using System.Security.Cryptography.X509Certificates;

bool booleano = true;
while (booleano) { 
Console.WriteLine("scegli l'operazione da effettuare: ");
Console.WriteLine("1: aprire il Conto");

Console.WriteLine("2: esci");
string scelta = Console.ReadLine();
    bool stato = false;
  ContoCorrente user= new ContoCorrente();
    switch(scelta){
        case "1":
            user.ApriConto();
            stato = true;
           
            if (stato && user.Saldo>=1000)
            {
                Console.WriteLine("Decidi la prossima operazione: ");
                Console.WriteLine("1: versare");
                Console.WriteLine("2: prelevare");
                Console.WriteLine("3: esci");
                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        user.Deposita();
                        break;
                    case "2":
                        user.Prelievo();
                        break;
                    case "3":
                        booleano = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Non hai deposito i 1000€ richiesti");
            }
                break;
        case "2":
            booleano = false;
            break;
    }
    
    
}
//2) Scrivere un algoritmo che prenda in input un valore di x nomi (decida il candidato la dimensione dell'array).
//Dopo aver caricato l'array, specificare un nome da ricercare e stampare se il nome è presente o
//meno nell'array caricato precedentemente.
