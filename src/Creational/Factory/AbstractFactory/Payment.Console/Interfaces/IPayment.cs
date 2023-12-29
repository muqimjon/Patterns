namespace Payment.Console.Interfaces;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}
