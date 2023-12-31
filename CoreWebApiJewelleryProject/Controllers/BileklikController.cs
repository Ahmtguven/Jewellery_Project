using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApiJewelleryProject.Model;
using Microsoft.Extensions.Hosting.Internal;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CoreWebApiJewelleryProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BileklikController : ControllerBase
	{
		public readonly ApplicationDbContext application;

		public BileklikController(ApplicationDbContext application)
		{
			this.application = application;
		}

		[HttpGet]
		public IActionResult IndexBileklik()
		{
			return Ok(application.bilekliklers.ToList());
		}

		[HttpGet("{Id}")]
		public IActionResult IndexBileklikId(int id)
		{
			return Ok(application.bilekliklers.Find(id));
		}

		[HttpPost]
		public IActionResult AddBileklik(Bileklikler bileklikler)
		{
			application.Add(bileklikler);
			application.SaveChanges();
			return Created("", bileklikler);
		}
		[HttpPut("{id}")]
		public IActionResult UpdateBileklik(int id, Bileklikler bileklikler)
		{
			var result = application.bilekliklers.FirstOrDefault(i =>i.BileklikId == id);
			result.BileklikAdi = bileklikler.BileklikAdi;
			result.BMadeni = bileklikler.BMadeni;
			result.BTaslari=bileklikler.BTaslari;
			result.Bucreti = bileklikler.Bucreti;
			result.Setlers = bileklikler.Setlers;
			application.SaveChanges();
			return NoContent();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBileklik(int id)
		{
			var delete = application.bilekliklers.FirstOrDefault(x => x.BileklikId == id);
			application.Remove(delete);
			application.SaveChanges();
			return NoContent();
		}
	}
}
