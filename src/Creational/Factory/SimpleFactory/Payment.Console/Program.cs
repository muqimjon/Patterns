// See https://aka.ms/new-console-template for more information

using Factory.Console.Commons;
using Factory.Console.Enums;
using Factory.Console.Interfaces;

IPayment payment = PaymentFactory.GetPayment(PaymentMethod.ApplePay);
payment.Pay(12000.00M);