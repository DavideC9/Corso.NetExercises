namespace EsercizioEU
{
    public class Citta 
    {
        
        public Cittadino _cittadino;
        public string _name;
        public int _popolazione;
        public string _moneta;
        public double _tassointeresse;
        private Citta citta;

        public Citta(string name, int popolazione, string moneta, double tassointeresse) 
        {
            _name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
        }


        public Citta(Cittadino cittadino)
        {
            _cittadino = cittadino;
            
        }

        


    }

}
  





