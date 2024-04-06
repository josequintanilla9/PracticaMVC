using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
	public class helpersDbContext : DbContext
	{
		public helpersDbContext(DbContextOptions  options) : base(options)
		{
		}

		public DbSet<usuario> usuario { get; set; }
	}
}
