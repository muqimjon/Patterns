using Factory.Console.Interfaces;

namespace Factory.Console.Services;

internal class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount} to merchant using a Pay Pal");
    }
}
