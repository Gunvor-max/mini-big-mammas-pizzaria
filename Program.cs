using mini_big_mammas_pizzaria.Model;
using mini_big_mammas_pizzaria.Services;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth", options =>
        {
            options.Cookie.Name = "MyCookieAuth";
        });

        services.AddAuthorization(options =>
        {
            services.Add("MustBelongToAdmin",
               policy => policy.RequireClaim("Pizzaria"));
        });
        
    }
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        //Indsætter pizzarepository
        builder.Services.AddSingleton<Menucard>(new Menucard());
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}

