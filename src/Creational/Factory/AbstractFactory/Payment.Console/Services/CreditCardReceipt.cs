using Payment.Console.Interfaces;

namespace Payment.Console.Services;

internal class CreditCardReceipt : IReceipt
{
    public void GenerateReceipt()
    {
        System.Console.WriteLine("Credit Card Receipt generated");
    }
}
