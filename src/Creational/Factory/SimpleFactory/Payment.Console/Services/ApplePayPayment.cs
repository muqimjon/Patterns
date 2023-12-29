using Factory.Console.Interfaces;

namespace Factory.Console.Services;

internal class ApplePayPayment : IPayment
{
    public void Pay(decimal amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount:C} to merchant using a Apple Pay");
    }
}
