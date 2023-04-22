using Sliit.MTIT.Payment.Data;
using Sliit.MTIT.Payment.Models;

namespace Sliit.MTIT.Payment.Services
{
    public class PaymentService : IPaymentService
    {
        public List<Models.Payment> GetPayments()
        {
            return PaymentMockDataService.Payments;
        }

        public Models.Payment? GetPayment(int id)
        {
            return PaymentMockDataService.Payments.FirstOrDefault(x => x.Id == id);
        }

        public Models.Payment? AddPayment(Models.Payment payment)
        {
            PaymentMockDataService.Payments.Add(payment);
            return payment;
        }

        public Models.Payment? UpdatePayment(Models.Payment payment)
        {
            Models.Payment selectedPayment = PaymentMockDataService.Payments.FirstOrDefault(x => x.Id == payment.Id);
            if (selectedPayment != null)
            {
                selectedPayment.CardNumber = payment.CardNumber;
                selectedPayment.ExpiryDate = payment.ExpiryDate;
                selectedPayment.CVC = payment.CVC;
                selectedPayment.Amount = payment.Amount;
                return selectedPayment;
            }

            return selectedPayment;
        }

        public bool? DeletePayment(int id)
        {
            Models.Payment selectedPayment = PaymentMockDataService.Payments.FirstOrDefault(x => x.Id == id);
            if (selectedPayment != null)
            {
                PaymentMockDataService.Payments.Remove(selectedPayment);
                return true;
            }
            return false;
        }

    }
}
