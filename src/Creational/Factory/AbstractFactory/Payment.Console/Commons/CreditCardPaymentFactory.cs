using Payment.Console.Interfaces;
using Payment.Console.Services;

namespace Payment.Console.Commons;

internal class CreditCardPaymentFactory : IPaymentFactory
{
    public IPayment CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }

    public IReceipt CreateReceipt()
    {
        return new CreditCardReceipt();
    }
}
