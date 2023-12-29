﻿using Payment.Console.Interfaces;

namespace Payment.Console.Services;

internal class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Cash Payment processed for amount {amount:C}");
    }
}