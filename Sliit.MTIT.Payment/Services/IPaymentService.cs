namespace Sliit.MTIT.Payment.Services
{
    public interface IPaymentService
    {
        List<Models.Payment> GetPayments();
        Models.Payment? GetPayment(int id);
        Models.Payment? AddPayment(Models.Payment payment);
        Models.Payment? UpdatePayment(Models.Payment payment);
        bool? DeletePayment(int id);
    }
}

