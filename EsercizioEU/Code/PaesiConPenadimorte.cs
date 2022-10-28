namespace EsercizioEU
{
    public class PaesiConPenadimorte : Paese, IPenaDiMorte
    {
        
        string _name;
        int _popolazione;
        string _moneta;
        double _tassointeresse;
        bool _penadimorte;
        


        public PaesiConPenadimorte (string name, int popolazione, string moneta, double tassointeresse,bool penadimorte): base ( name, popolazione, moneta,  tassointeresse, penadimorte)
        {
            /*_name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
            _penadimorte = penadimorte;
            */

        }

        public void PenaMorte(Paese paese)
        {
            if (paese._penadimorte)
            {
                System.Console.WriteLine(" Pena di morte Prevista " + paese.Name);
            }
            else { System.Console.WriteLine(" Pena di morte NON Prevista " + paese.Name); }
        }
    }

}




    
  





