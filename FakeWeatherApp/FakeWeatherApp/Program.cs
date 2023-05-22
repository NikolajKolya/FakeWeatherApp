using FakeWeatherApp.Services.Abstract;
using FakeWeatherApp.Services.Implementations;

namespace FakeWeatherApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            // DI
            builder.Services.AddScoped<IWeatherService, WeatherService>();

            // Сервисы могут быть добавлены 3мя способами:
            // 1) Singleton - для интерфейса 1 раз создается экземпляр класса и живёт всё время работы сервера
            // 2) Transient - экземпляр класса создаётся один раз на всё время работы контейнера
            // 3) PerRequest (он же Scoped) - такие экземпляры создаются каждый раз когда пользователь делает запрос

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // if (!app.Environment.IsDevelopment())
            // {
            //     app.UseExceptionHandler("/Home/Error");
            // }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}