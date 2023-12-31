using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApiJewelleryProject.Model;
using System.Linq;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CoreWebApiJewelleryProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SetlerController : ControllerBase
	{
		public readonly ApplicationDbContext application;

		public SetlerController(ApplicationDbContext application)
		{
			this.application = application;
		}

		[HttpGet]
		public IActionResult IndexSetler()
		{
			return Ok(application.setlers.ToList());
		}

		[HttpGet("{id}")]
		public IActionResult IndexSetlerId(int id)
		{
			return Ok(application.setlers.Find(id));
		}

		[HttpPost]
		public IActionResult AddSetler(Setler setler)
		{
			application.Add(setler);
			application.SaveChanges();
			return Created("", setler);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateSetler(int id, Setler setler) 
		{
			var result = application.setlers.Find(id);
			application.Update(result);
			application.SaveChanges();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteSetler(int id)
		{
			var result = application.setlers.Find(id);
			application.Remove(result);
			application.SaveChanges();
			return NoContent();
		}
	}
}
