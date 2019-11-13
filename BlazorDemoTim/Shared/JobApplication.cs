using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BlazorDemoTim.Shared
{
	public class JobApplication
	{
		[Required]
		public string Name { get; set; }
		[StringLength(50, ErrorMessage = "Too much.")]
		public string Description { get; set; }
		[Required]
		[Range(10000, 150000, ErrorMessage = "> 10K and < 150K") ]
		public int Salary { get; set; }
		[Required]
		public bool DoesOpenSource { get; set; }
		[Required]
		public DateTime AvailableDate { get; set; }
	}
}
