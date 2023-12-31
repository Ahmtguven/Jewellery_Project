using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApiJewelleryProject.Model;
using Microsoft.Extensions.Hosting.Internal;
using System.Linq;
using System.Net.WebSockets;

namespace CoreWebApiJewelleryProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class KupelerController : ControllerBase
	{
		public readonly ApplicationDbContext application;

		public KupelerController(ApplicationDbContext application)
		{
			this.application = application;
		}

		[HttpGet]
		public IActionResult IndexKupe()
		{
			return Ok(application.kupelers.ToList());
		}

		[HttpGet("{id}")]
		public IActionResult IndexKupeId(int id)
		{
			return Ok(application.kupelers.FirstOrDefault(i => i.KupeId == id));
		}

		[HttpPost]
		public IActionResult AddKupe(Kupeler kupeler)
		{
			application.Add(kupeler);
			application.SaveChanges();
			return Created("",kupeler);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateKupe(int id, Kupeler kupeler) 
		{
			var result = application.kupelers.Find(id);
			application.Update(kupeler);
			application.SaveChanges();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public  IActionResult DeleteKupe(int id)
		{
			var result = application.kupelers.FirstOrDefault(i=>i.KupeId==id);
			application.Remove(result);
			application.SaveChanges();
			return NoContent();
		}

	}
}
