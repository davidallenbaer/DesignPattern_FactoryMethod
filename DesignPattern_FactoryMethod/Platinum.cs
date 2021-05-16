namespace DesignPattern_FactoryMethod
{
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 135000;
        }
        public int GetAnnualCharge()
        {
            return 3000;
        }
    }
}