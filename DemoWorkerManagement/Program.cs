using DemoWorkerManagement.Context;

namespace DemoWorkerManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
                .AddMvc();

            builder.Services.AddDbContext<DataContext>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Worker}/{action=list}");

            app.Run();
        }
    }
}