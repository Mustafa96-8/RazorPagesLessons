using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Название"),StringLength(60,MinimumLength =3)]
        [Required]
        public string? Title { get; set; } = string.Empty;



        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [Display(Name = "Цена"), Range(10,2000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


        [Display(Name = "Жанр")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }



        [Display(Name = "Возрастной рейтинг")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } =string.Empty;

    }
}
