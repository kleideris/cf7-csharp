using Serilog;
using Serilog.Events;
using WebAppStarter_DB.Configuration;
using WebAppStarter_DB.DAO;
using WebAppStarter_DB.Services;

namespace WebAppStarter_DB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IStudentDAO, StudentDAOImpl>();
            builder.Services.AddScoped<IStudentService, StudentServiceImpl>();

            builder.Services.AddAutoMapper(cfg => { cfg.AddMaps(typeof(MapperConfig).Assembly); });
            builder.Host.UseSerilog((context, config) =>
            {
                config.ReadFrom.Configuration(context.Configuration);
                //config
                //.MinimumLevel.Debug()
                //.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                //.Enrich.FromLogContext()
                ////.Enrich.WithAspNetCore()
                //.WriteTo.Console()
                //.WriteTo.File(
                //    "Logs/Logs.txt",
                //    RollingInterval: RollingInterval.Day,
                //    outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss:fff zzz} {SourceContext} [{Debug}] " +
                //        "{Message}{NewLine}{Exception}",
                //    retainedFileCountLimit: null,
                //    fileSizeLimitBytes: null
                //    );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
