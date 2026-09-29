namespace SkopjeDrive.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public string Category { get; set; } = "";
        public int Seats { get; set; }
        public string Transmission { get; set; } = "";
        public decimal PricePerDay { get; set; }
        public string ImageURL { get; set; } = "";
        
    }
}
