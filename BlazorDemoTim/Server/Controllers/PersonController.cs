using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemoTim.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BlazorDemoTim.Server.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
    {
		[HttpGet]
		[Route("all")]
		public IEnumerable<PersonModel> GetPeople()
		{
			return new List<PersonModel> {
				new PersonModel
				{
					FirstName = "Mike",
					LastName = "Lyncheski",
					AccountBalance = -48.17M
				},
				new PersonModel
				{
					FirstName = "Kristyn",
					LastName = "Lyncheski",
					AccountBalance = 8.17M
				},
				new PersonModel
				{
					FirstName = "Ann Marie",
					LastName = "Rillo",
					AccountBalance = 148.17M
				}
			};
		}

		[HttpPost]
		public void Post(PersonModel person)
		{

		}
	}
}