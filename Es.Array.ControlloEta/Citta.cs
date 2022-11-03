using System;
using System.Collections.Generic;

namespace EsercizioArray
{
    public class Citta
    {
        public string _nome;
        public int _numMaxabitanti;
        
        public List<Cittadino> _Anagrafica = new();
        
        public Citta(string nome, int numMaxabitanti)
        {
            _nome = nome;
            _numMaxabitanti = numMaxabitanti;
        }

        public void AggiungiCittadino(Cittadino nuovoCittadino)
        {

            
            if (_Anagrafica.IndexOf(nuovoCittadino) == -1 && _Anagrafica.Count < _numMaxabitanti )
            {
                if (nuovoCittadino._eta >= 18) { 
                    _Anagrafica.Add(nuovoCittadino);
                }
                else
                {
                    Console.WriteLine("il cittadino non puo'iscriversi");
                }
            }
            else
            {
                Console.WriteLine("La città è al completo ");
            }

            
        }



        



    }
}

