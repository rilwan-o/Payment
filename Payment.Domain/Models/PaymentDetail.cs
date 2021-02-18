using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Domain.Models
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string RequestId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
