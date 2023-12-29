using Factory.Console.Interfaces;

namespace Factory.Console.Services;

internal class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount:C} to merchant using a Pay Pal");
    }
}
