using Microsoft.EntityFrameworkCore;
namespace CoreWebApiJewelleryProject.Model
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{

		}
		public DbSet<Bileklikler> bilekliklers { get; set; }
		public DbSet<Kolyeler> kolyelers { get; set; }
		public DbSet<Kupeler> kupelers { get; set; }
		public DbSet<Yuzukler> yuzuklers { get; set;}
		public DbSet<Setler> setlers { get; set; }
	}
}
