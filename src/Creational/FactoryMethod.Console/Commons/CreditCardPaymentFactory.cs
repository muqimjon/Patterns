using FactoryMethod.Console.Services;
using FactoryMethod.Console.Interfaces;

namespace FactoryMethod.Console.Commons;

internal class CreditCardPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
    {
        return new CreditCardPayment();
    }
}
