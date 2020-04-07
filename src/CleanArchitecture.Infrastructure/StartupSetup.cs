using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
	public static class StartupSetup
	{
		public static void AddDbContext(this IServiceCollection services, IConfiguration configuration) =>
	         services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(
					configuration.GetConnectionString("DefaultConnection"),
					b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
		//services.AddDbContext<AppDbContext>(options =>
		//	options.UseSqlServer("Data Source=database.sqlite")); // will be created in web project root
	}
}
