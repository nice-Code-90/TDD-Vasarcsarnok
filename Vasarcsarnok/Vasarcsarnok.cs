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
            if (kg >= 5)
            {
                total *= 0.9;
            }
            return total;
        }
    }
}