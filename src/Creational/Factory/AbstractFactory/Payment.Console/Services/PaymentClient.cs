using Payment.Console.Commons;
using Payment.Console.Interfaces;

namespace Payment.Console.Services;

internal class PaymentClient(IPaymentFactory paymentFactory)
{
    private IPayment paymentMethod = paymentFactory.CreatePaymentMethod();
    private IReceipt receipt = paymentFactory.CreateReceipt();

    public void ProcessPayment(decimal amount)
    {
        paymentMethod.ProcessPayment(amount);
    }

    public void GenerateReceipt()
    {
        receipt.GenerateReceipt();
    }
}
