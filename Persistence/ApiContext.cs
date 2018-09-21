using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Persistence
{
	public class ApiContext: DbContext
	{
		public DbSet<User> Users {get; set;}
		public DbSet<Comment> Comments {get; set;}
		public DbSet<Photo> Photos {get; set;}
		public DbSet<Reaction> Reactions {get; set;}
		public DbSet<Post> Posts {get; set;}
		public ApiContext(DbContextOptions<ApiContext> options): base(options) {}


	}
}
