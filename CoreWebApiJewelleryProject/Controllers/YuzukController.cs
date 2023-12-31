using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebApiJewelleryProject.Model;
using System.Linq;
using Microsoft.Extensions.Hosting.Internal;

namespace CoreWebApiJewelleryProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class YuzukController : ControllerBase
	{
		public readonly ApplicationDbContext application;
		public YuzukController(ApplicationDbContext application)
		{
			this.application = application;
		}

		[HttpGet]
		public IActionResult IndexYuzuk()
		{
			return Ok(application.yuzuklers.ToList());
		}

		[HttpGet("{id}")]
		public IActionResult IndexYuzukId(int id)
		{
			return Ok(application.yuzuklers.Find(id));
		}

		[HttpPost]
		public IActionResult AddYuzuk(Yuzukler yuzukler)
		{
			application.Add(yuzukler);
			application.SaveChanges();
			return Created("", yuzukler);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateYuzuk(int id, Yuzukler yuzukler)
		{
			var result = application.yuzuklers.Find(id);
			application.Update(yuzukler);
			return NoContent();
		}

		[HttpDelete]
		public IActionResult DeleteYuzuk(int id)
		{
			var result = application.yuzuklers.Find(id);
			application.Remove(result);
			return NoContent();
		}
	}
}
