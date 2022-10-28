

namespace EsercizioEU
{
    public class Paese
    {
        public Regione _regione;
        string _name;
        int _popolazione;
        string _moneta;
        double _tassointeresse;
        public bool _penadimorte;


       
        public Paese(string name, int popolazione, string moneta, double tassointeresse, bool penadimorte) 
        {
            _name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
            _penadimorte = penadimorte;
            
    }


        /*public Paese( Regione _regione)
        {
            _regione = new Regione();
        }*/


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Popolazione
        {
            get => _popolazione;
            set => _popolazione = value;

        }
        public string Moneta
        {
            get => _moneta;
            set => _moneta = value;
        }

        public double TassoInteresse
        {
            get => _tassointeresse;
            set => _tassointeresse = value;
        }



        

        /*public void AddPaese() {

            Paese paese = new Paese(Name,poop);

            System.Console.Write("Enter the name of country: ");
            paese._name = System.Console.ReadLine();

            System.Console.Write("Scrivi il nome della moneta: ");
            paese._moneta = System.Console.ReadLine();

            System.Console.Write("Scrivi numero popolazione: ");
            paese._popolazione = int.Parse(System.Console.ReadLine());

            System.Console.Write("Scrivi numero popolazione: ");
            paese._popolazione = int.Parse(System.Console.ReadLine());
        }*/


        public void controlloEurozona(Paese paese)
        {

            if (paese._moneta.ToLower().Contains("euro")) {

                System.Console.Write("Hanno l euro"); }




            else { System.Console.Write("non hanno l euro"); }




        }

        
    }
} 





