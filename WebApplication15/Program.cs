using Microsoft.EntityFrameworkCore;
using WebApplication15.Data;
using WebApplication15.Services; 

var builder = WebApplication.CreateBuilder(args);

// Отримуємо рядок підключення
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Реєструємо DbContext з використанням SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Додаємо сервіси MVC
builder.Services.AddControllersWithViews();


// Реєстрація IOmdbService у DI-контейнері
builder.Services.AddScoped<IMovieService, SqliteMovieService>();

var app = builder.Build();

// Автоматичне створення БД та застосування міграцій при запуску
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    // Створює БД та таблиці за наявною моделлю, ігноруючи міграції
    dbContext.Database.EnsureCreated();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();