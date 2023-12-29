﻿// See https://aka.ms/new-console-template for more information

using Payment.Console.Commons;
using Payment.Console.Interfaces;

PaymentFactory creditCardFactory = new CreditCardPaymentFactory();
IPayment creditCardPayment = creditCardFactory.CreatePayment();
creditCardPayment.ProcessPayment(10000.55M);

PaymentFactory cashFactory = new CashPaymentFactory();
IPayment cashPayment = cashFactory.CreatePayment();
cashPayment.ProcessPayment(15151000.00M);