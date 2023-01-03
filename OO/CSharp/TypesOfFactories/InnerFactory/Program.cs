using InnerFactory.Classes;

var blackCard = CreditCardPayment.Factory.GenerateCreditCardPaymentBlack(9000);
Console.WriteLine($"With the black credit card you shoul pay {blackCard.FinalAmountToPay()}");

var platinumCard = CreditCardPayment.Factory.GenerateCreditCardPaymentPlatinum(9000);
Console.WriteLine($"With the black credit card you shoul pay {platinumCard.FinalAmountToPay()}");