using System.Data.Entity;
using ZumoCommunity.BlogAPI.Data.Entity;

namespace ZumoCommunity.BlogAPI.Data.Context
{
	public class DataContext : DbContext
	{
		public DataContext()
			: base("Database")
		{
		}

		public DataContext(string connectionString)
			: base(connectionString)
		{
		}

		public DbSet<Post> Posts { get; set; }
		public DbSet<Tag> Tags { get; set; }
	}
}
