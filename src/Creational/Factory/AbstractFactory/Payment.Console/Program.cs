// See https://aka.ms/new-console-template for more information

using Payment.Console.Commons;
using Payment.Console.Services;

IPaymentFactory creditCardFactory = new CreditCardPaymentFactory();
PaymentClient creditCardClient = new PaymentClient(creditCardFactory);
creditCardClient.ProcessPayment(150.75m);
creditCardClient.GenerateReceipt();

Console.WriteLine();

IPaymentFactory cashFactory = new CashPaymentFactory();
PaymentClient cashClient = new PaymentClient(cashFactory);
cashClient.ProcessPayment(75.50m);
cashClient.GenerateReceipt();