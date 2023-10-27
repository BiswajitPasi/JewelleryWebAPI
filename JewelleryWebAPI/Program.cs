using JewelleryWebAPI.Context;
using JewelleryWebAPI.Interfaces.Manager;
using JewelleryWebAPI.Manager;
using Microsoft.EntityFrameworkCore;

namespace JewelleryWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddTransient<ICategoryManager, CategoryManager>();
            builder.Services.AddTransient<IProductManager, ProductManager>();
            builder.Services.AddTransient<IFileUploadManager, FileUploadManager>();
            builder.Services.AddTransient<ICartManager, CartManager>();
            builder.Services.AddTransient<IUserManager, UserManager>();
            builder.Services.AddTransient<IBlockManager, BlockManager>();
            builder.Services.AddTransient<ICustomerManager, CustomerManager>();
            builder.Services.AddTransient<ISOMManager, SOMManager>();
            builder.Services.AddTransient<ISODManager, SODManager>();
            builder.Services.AddTransient<IStockManager, StockManager>();
            builder.Services.AddTransient<IProfitrangeManager, ProfitrangeManager>();
            builder.Services.AddTransient<IModelNoManager, ModelNoManager>();
            //builder.Services.AddScoped<ICategoryManager, CategoryManager>();
            //builder.Services.AddSingleton<ICategoryManager, CategoryManager>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApiVersioning(options=>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseStaticFiles();
            // app.UseHttpsRedirection();
            app.UseApiVersioning();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}