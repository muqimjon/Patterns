using FactoryMethod.Console.Interfaces;

namespace FactoryMethod.Console.Commons;

internal abstract class PaymentFactory
{
    public abstract IPayment CreatePayment();
}
