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
            return unitPrice * kg;
        }
    }
}