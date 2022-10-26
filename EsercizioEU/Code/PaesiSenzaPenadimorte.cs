namespace EsercizioEU
{
    public class PaesiSenzaPenadimorte : PUnioneEuropea
    {

        string _name;
        int _popolazione;
        string _moneta;
        double _tassointeresse;
        bool _penadimorte;
        bool _contrattoUE;
        private bool leggiUE;

        public PaesiSenzaPenadimorte(string name, int popolazione, string moneta, double tassointeresse, bool contrattoUE, bool penadimorte, bool leggiEU) : base ( name,popolazione, moneta,  tassointeresse, contrattoUE,  penadimorte, leggiEU)
        {
            _name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
            _penadimorte = penadimorte;
            _contrattoUE = contrattoUE;
            this._leggiEU = leggiUE;



        }
    }
}
    
  





