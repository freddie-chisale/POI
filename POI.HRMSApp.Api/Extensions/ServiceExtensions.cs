using Microsoft.EntityFrameworkCore;
using POI.HRMSApp.Contracts;
using POI.HRMSApp.Entities;
using POI.HRMSApp.LoggerService;
using POI.HRMSApp.Repository;

namespace POI.HRMSApp.Api.Extensions;

public static class ServiceExtensions
{
  public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
      options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());
    });

  public static void ConfigureIISIntegration(this IServiceCollection services) =>
    services.Configure<IISOptions>(options =>
    {
    });
  
  public static void ConfigureLoggerService(this IServiceCollection services) =>
    services.AddScoped<ILoggerManager, LoggerManager>();
  
  public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
    services.AddDbContext<HRMSDataContext>(opts =>
      opts.UseSqlServer(configuration.GetConnectionString("DBConnection"), b =>
        b.MigrationsAssembly("POI.HRMSApp.Api")));

}