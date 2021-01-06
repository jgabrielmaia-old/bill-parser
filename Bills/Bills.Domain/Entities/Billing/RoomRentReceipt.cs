using System;

namespace Bills.Domain.Entities
{
    public class RoomRentReceipt : Bill
    {
        public decimal DailyFare { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int EmployeeId { get; set; }
    }
}
