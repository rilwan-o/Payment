using Payment.Domain.Dtos;
using Payment.Domain.Interfaces.PaymentProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Data
{
    public class PremiumPaymentGateway : IPaymentGateway
    {
        public Response ProcessPayment(PaymentDetailRequestDto paymentDetailRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
