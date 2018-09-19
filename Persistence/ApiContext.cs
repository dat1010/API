using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Persistence
{
	public class ApiContext: DbContext
	{
		public DbSet<User> Users {get; set;}
		public ApiContext(DbContextOptions<ApiContext> options): base(options) {}


	}
}
