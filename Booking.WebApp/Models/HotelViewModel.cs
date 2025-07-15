namespace Booking.WebApp.Models
{
    public class HotelViewModel
    {
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal ReviewScore { get; set; }
        public string ReviewScoreWord { get; set; }
        public string City { get; set; }
        public string Price { get; set; }
    }
}
