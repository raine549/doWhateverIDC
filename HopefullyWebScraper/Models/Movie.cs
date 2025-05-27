using System.ComponentModel.DataAnnotations;

namespace HopefullyWebScraper.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }  
        public string? Genre { get; set; } 
        public decimal Price { get; set; }

        ///the Movie class contains:
        ///  ID field is required by the database for the primary key
        ///  a [DataType] attribute that specicies data type in ReleaseDate property
        ///  thanks to this attribute:
        ///    user isnt required to enter time info in date field
        ///    only date is displayed, not time
        ///  the question mark after string indicated that the property is nullable
    }
}
