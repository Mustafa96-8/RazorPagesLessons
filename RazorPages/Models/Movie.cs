using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string? Title { get; set; } = string.Empty;
        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Жанр")]
        public string? Genre { get; set; }
        [Display(Name = "Цена"), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; } =string.Empty;

    }
}
