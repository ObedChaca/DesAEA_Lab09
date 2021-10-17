using System;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

}