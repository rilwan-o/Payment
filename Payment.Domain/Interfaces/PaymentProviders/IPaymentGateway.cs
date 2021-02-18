using Payment.Domain.Data;
using Payment.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Interfaces.PaymentProviders
{
    public interface IPaymentGateway
    {
        Response ProcessPayment(PaymentDetailRequestDto paymentDetailRequestDto);
    }
}
