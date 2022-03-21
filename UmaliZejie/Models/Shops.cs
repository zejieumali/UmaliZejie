using System.ComponentModel.DataAnnotations;

namespace UmaliZejie.Models
{
    public class Shops
    {
        public int ID { get; set; }
        public string Product { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
