namespace MVCBooking.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public required string GuestName { get; set; }
        public int RoomNumber { get; set; }
    }
}
