namespace FactoryMethod.Classes
{
    public class CreditCardPayment
    {
        public static CreditCardPayment GenerateCreditCardPaymentBlack(decimal amount)
        {
            var cp = new CreditCardPayment();
            cp.AmountToPay = amount;
            cp.Discout = 10;

            return cp;
        }

        public static CreditCardPayment GenerateCreditCardPaymentPlatinum(decimal amount)
        {
            var cp = new CreditCardPayment();
            cp.AmountToPay = amount;
            cp.Discout = 5;

            return cp;
        }

        private CreditCardPayment()
        {

        }

        public decimal AmountToPay { get; set; }
        public decimal Discout { get; set; }

        public decimal FinalAmountToPay()
        {
            return AmountToPay * (100 - Discout) / 100;
        }
    }
}
