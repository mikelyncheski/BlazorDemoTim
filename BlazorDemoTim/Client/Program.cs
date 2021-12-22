//c1+c2+c3+c4
using Microsoft.AspNetCore.Blazor.Hosting;
// c5
namespace BlazorDemoTim.Client
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
			BlazorWebAssemblyHost.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();
	}
}
