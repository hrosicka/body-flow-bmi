namespace BmiAplikace.Models
{
    public class BmiModel
    {
        public double Hmotnost { get; set; }
        public double Vyska { get; set; }
        public double VysledekBmi { get; set; }

        public void SpocitejBmi()
        {
            if (Vyska > 0)
            {
                // Převod výšky z centimetrů na metry
                double vyskaVMetrech = Vyska / 100.0;
                VysledekBmi = Hmotnost / (vyskaVMetrech * vyskaVMetrech);
            }
            else
            {
                VysledekBmi = 0; // Nebo jiná indikace chyby
            }
        }
    }
}