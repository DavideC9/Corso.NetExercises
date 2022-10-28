using System;
using System.Xml.Linq;
using static EsercizioEU.Program;

namespace EsercizioEU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PaesiEurozona eurozona = new PaesiEurozona();

            Regione MOLISE = new Regione("Molise",123000, "euro",22);

            Paese paese = new Paese("Italia", 1000000, "euro", 22, false);

            Citta Firenze 

            PaesiConPenadimorte paeseM = new PaesiConPenadimorte ("name", 10, "euro",25, true);


            /*
            System.Console.Write("Enter the name of country: ");
            eurozona._name = System.Console.ReadLine();

            System.Console.Write("Scrivi il nome della moneta: ");
            eurozona._moneta = System.Console.ReadLine();

            System.Console.Write("Scrivi numero popolazione: ");
            eurozona._popolazione = int.Parse(System.Console.ReadLine());

            System.Console.Write("Scrivi numero tasso: ");
            eurozona._tassointeresse = double.Parse(System.Console.ReadLine());


            System.Console.Write("Nome Paese" + eurozona._name + "Nome moneta: " + eurozona._moneta + "Popolazione" + eurozona._popolazione);
            */
            System.Console.Write("\n Nome Paese" + paeseM.Name + "\n Nome moneta: " + paeseM.Moneta + "\n Popolazione" + paeseM.Popolazione +
                "tasso interesse" + paeseM.TassoInteresse + "pena di morte" + paeseM._penadimorte);

            System.Console.Write("\n Nome Paese" + paese.Name + "\n Nome moneta: " + paese.Moneta + "\n Popolazione" + paese.Popolazione +
                "tasso interesse" + paese.TassoInteresse + "pena di morte" + paese._penadimorte);





        }
    }
}
  





