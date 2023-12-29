using FactoryMethod.Console.Interfaces;

namespace FactoryMethod.Console.Services;

internal class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Credit Card Payment processed for amount {amount:C}");
    }
}
