namespace StockPhoto.Entities
{
    public class AltPhoto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Link { get; set; }

        public string? Original_Size { get; set; }

        public DateTimeOffset Date_Of_Creation { get; set; }

        public string Author { get; set; } = string.Empty;

        public string Cost { get; set; } = String.Empty;

        public string? Num_of_Sales { get; set; }

        public string? Photo_Rating { get; set; }
    }
}
