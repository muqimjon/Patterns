using Factory.Console.Interfaces;

namespace Factory.Console.Services;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount} to merchant using a Credit Card");
    }
}
