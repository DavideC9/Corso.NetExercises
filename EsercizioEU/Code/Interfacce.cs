namespace EsercizioEU
{
    

    interface IEuroCentralBank
    {
        void calcoloSpread(PUnioneEuropea Pue);
        
    }

    interface ICorteEuropea
    {
        public void ControlloDirittiUmani( PUnioneEuropea Pue);
    }

    interface IONU
    {
        public void AccessoOnu();
    }

    interface IUnioneEuropea
    {
        void firmaContrattiUE(PUnioneEuropea Pue);

    }

    interface IPenaDiMorte
    {
        public void PenaMorte(Paese paese);
    }



}





