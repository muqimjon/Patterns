using FactoryMethod.Console.Services;
using FactoryMethod.Console.Interfaces;

namespace FactoryMethod.Console.Commons;

internal class CashPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
    {
        return new CashPayment();
    }
}