using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace BlazorDemoTim.Shared
{
	public static class JsonOptions
	{
		public static readonly JsonSerializerOptions Default = new JsonSerializerOptions
		{
			WriteIndented = true
		};
	}
}
