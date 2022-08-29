namespace StockPhoto.Entities
{
    public class AltText
    {
        public int Id { get; set; }

        public string Text_Name { get; set; } = string.Empty;

        public string Text_Title { get; set; } = string.Empty;

        public DateTimeOffset Datetime { get; set; }

        public string Cost { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Number_of_sales { get; set; } = string.Empty;

        public string Text_Rating { get; set; } = string.Empty;
    }
}
