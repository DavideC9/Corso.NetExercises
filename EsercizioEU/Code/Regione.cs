namespace EsercizioEU
{
    public class Regione 
    {
        public Paese paese;
        public string _name { get; set; }
        public int _popolazione { get; set; }
        public string _moneta { get; set; }
        public double _tassointeresse { get; set; }


        public Regione(string name, int popolazione, string moneta, double tassointeresse)
        {
            _name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
        }

        /*public Regione(string name, string moneta)
        {
            _name = name;
            _moneta = moneta;
            
        }*/

        
    }
}
  





