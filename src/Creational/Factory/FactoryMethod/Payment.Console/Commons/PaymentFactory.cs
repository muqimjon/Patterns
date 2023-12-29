using Payment.Console.Interfaces;

namespace Payment.Console.Commons;

internal abstract class PaymentFactory
{
    public abstract IPayment CreatePayment();
}
