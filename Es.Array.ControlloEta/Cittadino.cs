using System;

namespace EsercizioArray
{
    public class Cittadino
    {
        public string _nome;
        public string _cognome;
        public string _indirizzo;
        public string _datadinascita;
        public int _eta;
        public DateTime _date1 = DateTime.Today;
        public Citta _citta;

        public Cittadino(string nome, string cognome,int eta, string indirizzo, string datadinascita ,Citta citta)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = EtaDiagnosi();
            _citta = citta;
            _datadinascita = InserisciDatadiNascita();
            _indirizzo = indirizzo;
            
        }

        





        public string InserisciDatadiNascita()
        {
            Console.WriteLine("Inserire data di Nascita: ");
            string datadinascita = Console.ReadLine();

            

            if (DateTime.TryParse(datadinascita, out _date1))
            {
                
                Console.WriteLine($"Data di nascita: {_date1.ToString("D")}");
                

            }
            else
            {
                Console.WriteLine($"Data di nascita non corretta ");

            }
            return datadinascita;
        }


        public int EtaDiagnosi()
        {
            DateTime dataNas = DateTime.Parse(_datadinascita);
            var eta = (dataNas.Year - _date1.Year);

            if (eta >= 18)
            {
                Console.WriteLine("puo'iscriversi ");
            }
            else
            {
                Console.WriteLine("non puo'iscriversi ");
            }
            return eta;
        }

    }
}

