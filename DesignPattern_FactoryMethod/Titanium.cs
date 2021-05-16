namespace DesignPattern_FactoryMethod
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 125000;
        }
        public int GetAnnualCharge()
        {
            return 250;
        }
    }
}