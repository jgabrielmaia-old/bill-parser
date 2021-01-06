using System;

namespace Bills.Domain.Entities
{
    public class TaxiReceipt : Bill
    {
        public DateTime RideDate { get; set; }
    }
}
