using System.ComponentModel.DataAnnotations;

namespace WebApplication15.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть назву фільму")]
        [StringLength(100, ErrorMessage = "Назва не може бути довшою за 100 символів")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введіть ім'я режисера")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введіть жанр")]
        public string Genre { get; set; } = string.Empty;

        [Range(1888, 2030, ErrorMessage = "Некоректний рік випуску")]
        public int ReleaseYear { get; set; }

        public string PosterUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введіть опис")]
        [StringLength(1000, ErrorMessage = "Опис не може перевищувати 1000 символів")]
        public string Description { get; set; } = string.Empty;
    }
}