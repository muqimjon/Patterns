using Payment.Console.Interfaces;
using Payment.Console.Services;

namespace Payment.Console.Commons;

internal class CashPaymentFactory : IPaymentFactory
{
    public IPayment CreatePaymentMethod()
    {
        return new CashPayment();
    }

    public IReceipt CreateReceipt()
    {
        return new CashReceipt();
    }
}
