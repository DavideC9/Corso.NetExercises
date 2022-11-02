namespace EsercizioArray
{
    public class Cittadino
    {
        public string _nome;
        public string _cognome;
        public string _indirizzo;
        public Citta _citta;

        public Cittadino(string nome, string cognome,string indirizzo, Citta citta)
        {
            _nome = nome;
            _cognome = cognome;
            _citta = citta;
            _indirizzo = indirizzo;
        }
    }
}

