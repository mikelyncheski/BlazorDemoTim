using BlazorDemoTim.Client.Common;
using BlazorDemoTim.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;


//@inherits FetchDataBase
//@page "/fetchdata"
//@using WebApplication33.Data
//@inject WeatherForecastService ForecastService  https://www.telerik.com/blogs/using-a-code-behind-approach-to-blazor-components

// Partial class support is coming https://github.com/aspnet/AspNetCore/issues/5487


namespace BlazorDemoTim.Client.Pages
{
	public class FetchDataBase : ComponentBase
	{
		public WeatherForecast[]? forecasts;

		[Inject]
		public HttpClient? Http { get; set; }


		[CascadingParameter]
		UserState? UserState { get; set; }

		protected override async Task OnInitializedAsync()
		{
			Console.WriteLine("Fetching data ...");

			forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");

			UserState?.SetTemperature(forecasts.FirstOrDefault()?.TemperatureF);
			// Projects now use System.Text.Json by default for JSON
			Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(forecasts));
		}
	}
}
