using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.Services;

namespace OutpatientClinicsComplex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<OutpatientClinicsComplexContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            });
            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<IMinistryService, MinistryService>();
         
            builder.Services.AddHostedService<ReportBackgroundService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    policy =>
                    {
                        policy.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader();
                    });
            });


            var app = builder.Build();

            // ✅ Configure HTTP pipeline (بالترتيب الصحيح)
            /*  if (app.Environment.IsDevelopment())
              {
                  app.UseSwagger();
                  app.UseSwaggerUI();
              }*/
            app.UseSwagger();
            app.UseSwaggerUI();
            
            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthorization();
            
            // ✅ MapControllers هنا مش قبل
            app.MapControllers();

            // ✅ Seeding البيانات
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<OutpatientClinicsComplexContext>();
                    context.Database.EnsureCreated();
                    DbSeeder.SeedData(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "خطأ في Seed البيانات");
                }
            }

            app.Run();
        }
    }
}