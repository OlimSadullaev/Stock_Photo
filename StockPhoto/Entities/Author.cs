using System.Diagnostics.CodeAnalysis;

namespace StockPhoto.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string NickName { get; set; } = string.Empty;

        public DateTime Date_of_Birth { get; set; }

        public DateTime Date_of_Registration { get; set; }
    }
}
