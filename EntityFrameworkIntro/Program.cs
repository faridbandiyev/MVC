using EntityFrameworkIntro.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntro
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			//var conn1 = builder.Configuration.GetSection("ConnectionStrings").GetValue<string>("Default");

			//var conn2 = builder.Configuration.GetValue<string>("ConnectionStrings:Default");

			builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

			var app = builder.Build();

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
		}
	}
}