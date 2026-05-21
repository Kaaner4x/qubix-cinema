using System;

namespace QubixCinema.Entities.Models
{
    public class Register
    {
        public int RegisterId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public int MyProperty { get; set; }
    }
}
