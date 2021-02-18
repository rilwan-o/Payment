using Payment.Domain.Data;
using Payment.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Payment.UnitTest.Data
{
    public class CheapPaymentGatewayTest
    {
        [Fact]
        public void ProcessPayment_AmountLessThan20_ReturnSuccess()
        {
            PaymentDetailRequestDto paymentDetailRequestDto = new PaymentDetailRequestDto { 
                Amount = 19.0M,
                CardHolder = "Holder Name",
                CreditCardNumber = "12345678907",
                ExpirationDate = DateTime.Today.AddDays(2.0),
                RequestId = Guid.NewGuid().ToString(),
                SecurityCode = "123"
            };
            CheapPaymentGateway cheapPaymentGateway = new CheapPaymentGateway();

            var actual = cheapPaymentGateway.ProcessPayment(paymentDetailRequestDto);
            Assert.True(actual.Code.Equals("00"));
        }
    }
}
