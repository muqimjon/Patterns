using FactoryMethod.Console.Interfaces;

namespace FactoryMethod.Console.Services;

public class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Cash Payment processed for amount {amount:C}");
    }
}