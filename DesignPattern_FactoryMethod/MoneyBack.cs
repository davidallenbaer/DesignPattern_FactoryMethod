namespace DesignPattern_FactoryMethod
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 215000;
        }

        public int GetAnnualCharge()
        {
            return 7500;
        }
    }
}