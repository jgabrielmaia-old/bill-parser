using System;

namespace Bills.Domain.Entities
{
    public class EletricBill : Bill
    {
        public decimal BaseValue { get; set; }

        public float Charge { get; set; }

        public DateTime EmissionDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime PaidAtDate { get; set; }
    }
}
