namespace VasarcsarnokApp
{
    public class Vasarcsarnok
    {
        private readonly double unitPrice;

        public Vasarcsarnok(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public double GetAlmaAr(double kg)
        {
            double total = unitPrice * kg;
            if (kg >= 8) total *= 0.85;        // 15% kedvezmény 8 kg-tól
            else if (kg >= 5) total *= 0.9;    // 10% kedvezmény 5-7.99 kg között
            return total;
        }
    }
}