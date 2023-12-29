namespace Payment.Console.Interfaces;

internal interface IPayment
{
    void ProcessPayment(decimal amount);
}