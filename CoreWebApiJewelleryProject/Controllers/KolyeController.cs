using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApiJewelleryProject.Model;
using Microsoft.Extensions.Hosting.Internal;
using System.Linq;

namespace CoreWebApiJewelleryProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class KolyeController : ControllerBase
	{
		public readonly ApplicationDbContext application;
		public KolyeController(ApplicationDbContext application)
		{
			this.application = application;
		}

		[HttpGet]
		public IActionResult IndexKolye()
		{
			return Ok(application.kolyelers.ToList());
		}

		[HttpGet("{id}")]
		public IActionResult IndexKolyeId(int id)
		{
			return Ok(application.kolyelers.Find(id));
		}

		[HttpPost]
		public IActionResult AddKolye(Kolyeler kolyeler)
		{
			application.Add(kolyeler);
			application.SaveChanges();
			return Created("", kolyeler);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateKolye(int id, Kolyeler kolyeler)
		{
			var result = application.kolyelers.Find(id);
			result.KolyeAdi = kolyeler.KolyeAdi;
			result.KMadeni = kolyeler.KMadeni;
			result.KTaslari = kolyeler.KTaslari;
			result.Kucreti = kolyeler.Kucreti;
			result.Setlers = kolyeler.Setlers;
			application.SaveChanges();
			return NoContent();
		}

		[HttpGet("{id}")]
		public IActionResult DeleteKolye(int id)
		{
			var delete = application.kolyelers.Find();
			application.Remove(delete);
			application.SaveChanges();
			return NoContent();
		}

	}
}
