using System;

namespace EsercizioArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Citta Milano = new("Milano", 7500);

            Cittadino Mauro = new("Mauro", "Del Prete",  "via del furno", Milano);

            Milano.AggiungiCittadino(Mauro);

            Cittadino Fabio = new("Fabio", "Lauro", "via del catanio", Milano);

            Milano.AggiungiCittadino(Fabio);


            

            Citta Roma = new("Roma", 423456543);

            Cittadino Antonio = new("Antonio", "ranallo", "trastevere", Roma);

            Roma.AggiungiCittadino(Antonio);



            Milano._Anagrafica.ForEach(PrintCitizen);
            Roma._Anagrafica.ForEach(PrintCitizen);


            Console.WriteLine("\n");
        }

        static void PrintCitizen(Cittadino person)
        {
            Console.WriteLine("\nCitta':" + person._citta._nome);
            Console.WriteLine("Numero abitanti : " + person._citta._Anagrafica.Count + "\nNumero massimo di abitanti :"+ person._citta._numMaxabitanti +
                "\nNumero di abitanti ancora possibili:"+ (person._citta._numMaxabitanti - person._citta._Anagrafica.Count));
            Console.WriteLine("Nome : " + person._nome + "\nCognome: " + person._cognome + "\nIndirizzo: " + person._indirizzo );
            
      
        }

        
    }

    
}

