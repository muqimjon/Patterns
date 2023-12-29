using Payment.Console.Services;
using Payment.Console.Interfaces;

namespace Payment.Console.Commons;

internal class CashPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
    {
        return new CashPayment();
    }
}