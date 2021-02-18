using Payment.Domain.Dtos;
using Payment.Domain.Interfaces.PaymentProviders;
using Payment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Data
{
    public class CheapPaymentGateway : IPaymentGateway
    {
        public Response ProcessPayment(PaymentDetailRequestDto paymentDetailRequestDto)
        {
            throw new NotImplementedException();
        }

    }
}
