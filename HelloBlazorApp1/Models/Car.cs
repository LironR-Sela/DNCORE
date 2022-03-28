using System.ComponentModel.DataAnnotations;

namespace HelloBlazorApp1.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Color { get; set; }
    }
}
