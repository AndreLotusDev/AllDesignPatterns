using FactoryMethod.Classes;

var blackCard = CreditCardPayment.GenerateCreditCardPaymentBlack(9000);
Console.WriteLine($"With the black credit card you shoul pay {blackCard.FinalAmountToPay()}");

var platinumCard = CreditCardPayment.GenerateCreditCardPaymentPlatinum(9000);
Console.WriteLine($"With the black credit card you shoul pay {platinumCard.FinalAmountToPay()}");