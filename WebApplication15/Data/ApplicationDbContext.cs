using Microsoft.EntityFrameworkCore;
using WebApplication15.Models;

namespace WebApplication15.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Втеча з Шоушенка",
                    Director = "Френк Дарабонт",
                    Genre = "Драма",
                    ReleaseYear = 1994,
                    PosterUrl = "https://m.media-amazon.com/images/M/MVB0MTI4OTI4NTA4Ml5BMl5BanBnXkFtZTcwMzAxOTU3NQ@@._V1_FMjpg_UX1000_.jpg",
                    Description = "Бухгалтер Енді Дюфрейн облудно звинувачений у вбивстві дружини та її коханця. Його відправляють до суворої в'язниці Шоушенк."
                },
                new Movie
                {
                    Id = 2,
                    Title = "Темний лицар",
                    Director = "Крістофер Нолан",
                    Genre = "Екшн, Кримінал, Драма",
                    ReleaseYear = 2008,
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg",
                    Description = "Бетмен піднімає ставки у боротьбі з криміналом. За допомогою лейтенанта Джима Ґордона та прокурора Гарві Дента він намагається очистити Ґотем."
                },
                new Movie
                {
                    Id = 3,
                    Title = "Початок",
                    Director = "Крістофер Нолан",
                    Genre = "Наукова фантастика, Екшн",
                    ReleaseYear = 2010,
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX1000_.jpg",
                    Description = "Злодій, який викрадає корпоративні таємниці за допомогою технології обміну снами, отримує обернене завдання."
                },
                new Movie
                {
                    Id = 4,
                    Title = "Інтерстеллар",
                    Director = "Крістофер Нолан",
                    Genre = "Наукова фантастика, Драма",
                    ReleaseYear = 2014,
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    Description = "Колектив дослідників використовує нововиявлену червоточину, щоб подолати обмеження людських космічних польотів."
                },
                new Movie
                {
                    Id = 5,
                    Title = "Кримінальне чтиво",
                    Director = "Квентін Тарантіно",
                    Genre = "Кримінал, Драма",
                    ReleaseYear = 1994,
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BYTViYTE3ZGQtNDBlMC00MGUyLThhNWUtZGRjZmVkM2Y5OWNiXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    Description = "Життя двох бандитів, дружини гангстера, боксера та пари грабіжників переплітаються в чотирьох історіях."
                },
                new Movie
                {
                    Id = 6,
                    Title = "Матриця",
                    Director = "Лана та Ліллі Вачовскі",
                    Genre = "Наукова фантастика, Екшн",
                    ReleaseYear = 1999,
                    PosterUrl = "https://m.media-amazon.com/images/M/MV5BN2NmN2VhMTQtMDNiOS00NDlhLTliMjgtODE2N2VhMDY3M2NjXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                    Description = "Комп'ютерний хакер дізнається від таємничих заколотників про справжню природу своєї реальності."
                }
            );
        }
    }
}