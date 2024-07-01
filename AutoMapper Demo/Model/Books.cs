using System.ComponentModel.DataAnnotations;

namespace AutoMapper_Demo.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }
        public double Price { get; set; }
    }
}
