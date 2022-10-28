namespace EsercizioEU
{
    public class Cittadino 
    {
        public Citta _citta;
        public string _name;
        public string _cognome;
        public string _codicefiscale;
        public string _indirizzo;


        public Cittadino(string name, string cognome, string codicefiscale, string indirizzo)
        {
            _name = name;
            _cognome = cognome;
            _codicefiscale = codicefiscale;
            _indirizzo = indirizzo;
        }


        public Cittadino( string name, Citta citta)

        {

            this._name = name;
            _citta._cittadino = this;

        }




       


    }
}
  





