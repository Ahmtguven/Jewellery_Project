using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CoreWebApiJewelleryProject.Model
{
	public class Setler
	{
		[Key]
		public int SetId { get; set; }
		public string SetAdi { get; set; }
		public ICollection<Bileklikler> Bilekliklers { get; set; }
		public ICollection<Kolyeler> Kolyelers { get; set; }
		public ICollection<Kupeler> Kupelers { get; set; }
		public ICollection<Yuzukler> Yuzuklers { get; set; }
	}
}
