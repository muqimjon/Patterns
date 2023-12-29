using Factory.Console.Interfaces;

namespace Factory.Console.Services;

internal class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount} to merchant using a Google Pay");
    }
}
