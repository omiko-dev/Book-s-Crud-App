using nika.Enums;
using System.ComponentModel.DataAnnotations;

namespace nika.Models
{
    public class Book
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public Author? Author { get; set; }

        [Required]
        public Publisher? Publicher { get; set; }

        [Required]
        public Language? Language { get; set; }

        [Required]
        public Genre? Genre { get; set; }

        [Required]
        public Shelf? Shelf { get; set; }

    }
}
