using Factory.Console.Enums;
using Factory.Console.Services;
using Factory.Console.Interfaces;

namespace Factory.Console.Commons;

internal class PaymentFactory
{
    public static IPayment GetPayment(PaymentMethod paymentMethod)
        => paymentMethod switch
        {
            PaymentMethod.CreditCard => new CreditCardPayment(),
            PaymentMethod.ApplePay => new ApplePayPayment(),
            PaymentMethod.GooglePay => new GooglePayPayment(),
            PaymentMethod.PayPal => new PayPalPayment(),
            _ => throw new NotSupportedException($"{paymentMethod} is currently not supported as a payment method.")
        };
}
