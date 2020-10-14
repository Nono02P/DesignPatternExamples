using System;

namespace DesignPattern.State
{
    public class PaymentService : IPaymentService
    {
        public ePaymentResult Pay()
        {
            return new Random().Next(100) >= 50 ? ePaymentResult.Failed : ePaymentResult.Ok;
        }
    }
}