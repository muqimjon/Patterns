using Payment.Console.Interfaces;

namespace Payment.Console.Services;

internal class CashReceipt : IReceipt
{
    public void GenerateReceipt()
    {
        System.Console.WriteLine("Cash Receipt generated");
    }
}