using Factory.Console.Interfaces;

namespace Factory.Console.Services;

public class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        System.Console.WriteLine($"Succesfully paid {amount:C} to merchant using a Credit Card");
    }
}
