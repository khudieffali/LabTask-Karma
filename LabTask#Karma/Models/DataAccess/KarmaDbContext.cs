using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LabTask_Karma.Models.DataAccess
{
	public class KarmaDbContext(DbContextOptions<KarmaDbContext> options) : DbContext(options) 
	{
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
