using Payment.Console.Interfaces;

namespace Payment.Console.Commons;

public interface IPaymentFactory
{
    IPayment CreatePaymentMethod();
    IReceipt CreateReceipt();
}