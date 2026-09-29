namespace SkopjeDrive.Models
{
    public class NewsPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime Date { get; set; }
    }
}
