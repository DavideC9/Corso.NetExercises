namespace EsercizioEU
{

    public class PUnioneEuropea : Paese , IEuroCentralBank , ICorteEuropea ,IONU, IUnioneEuropea
    {
        string _name;
        int _popolazione;
        string _moneta;
        double _tassointeresse;
        double _spread;
        bool _contrattoUE;
        bool _penadimorte;
        public bool _leggiEU;



      



        public PUnioneEuropea (string name, int popolazione, string moneta, double tassointeresse, bool contrattoUE, bool penadimorte,bool leggiEU):base ( name,popolazione,moneta, tassointeresse, penadimorte)
        {


            /*_name = name;
            _popolazione = popolazione;
            _moneta = moneta;
            _tassointeresse = tassointeresse;
            _spread = calcoloSpread();
            _contrattoUE = contrattoUE;
            */

            this._penadimorte = penadimorte;
            this._leggiEU = leggiEU;
        }

        

        public void PenaMorte(Paese paese)
        {
            if (paese._penadimorte)
            {
                System.Console.WriteLine(" Pena di morte Prevista " + paese.Name);
            }
            else { System.Console.WriteLine(" Pena di morte NON Prevista " + paese.Name); }


        }

        public  void firmaContrattiUE(PUnioneEuropea Pue)
        {
            if (Pue._contrattoUE) { 
                System.Console.WriteLine(" Il paese fa parte dell unione europea " );
        }
            else { System.Console.WriteLine("Non fa parte dell unione europea " ); }


}

        public void calcoloSpread(PUnioneEuropea pUnioneEuropea)
        {
            System.Console.WriteLine((pUnioneEuropea._tassointeresse - 1) * 100);
        }


        public void ControlloDirittiUmani( PUnioneEuropea Pue)
        {
            if (Pue._leggiEU)
            {

                System.Console.WriteLine(" Rispetta diritti umani");
            }else
                System.Console.WriteLine("Non Rispetta diritti umani");
        }

        public void AccessoOnu()
        {
            throw new System.NotImplementedException();
        }
    }




}





