using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        //specify datetime to just date
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public Decimal Price { get; set; }
    }
}

