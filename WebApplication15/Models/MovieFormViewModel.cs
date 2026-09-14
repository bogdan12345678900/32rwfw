using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication15.Models
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть назву фільму")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введіть ім'я режисера")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введіть жанр")]
        public string Genre { get; set; } = string.Empty;

        [Range(1888, 2030, ErrorMessage = "Некоректний рік")]
        public int ReleaseYear { get; set; } = DateTime.Now.Year;

        [Required(ErrorMessage = "Введіть опис")]
        public string Description { get; set; } = string.Empty;

        public string? ExistingPosterPath { get; set; }

        public IFormFile? PosterFile { get; set; }
    }
}