namespace Ravit
{
    struct Veikkauslippu
    {
        private int kilpailunumero;
        private float summa;
        private bool lunastettu;
        public Veikkauslippu(int kilpailunumero, float summa)
        {
            this.kilpailunumero = kilpailunumero;
            this.summa = summa;
            lunastettu = false;
        }
        public void Lunasta()
        {
            lunastettu = true;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine($"Veikkaus: numerolle {kilpailunumero}: {summa} euroa");
        }
    }
}