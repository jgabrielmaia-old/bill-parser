using System;

namespace Bills.Domain.Entities
{
    public class VehicleRentReceipt : Bill
    {
        public decimal DailyFare { get; set; }
        
        public DateTime RentDate { get; set; }

        public int NumberOfDaysRented { get; set; }

        public int EmployeeId { get; set; }
    }
}
