using API.Models;
using API.Persistence;

namespace TradehoundsApi
{
	public class Accounts
	{
		private ApiContext _context;
		public Accounts(ApiContext context)
		{
			_context = context;
		}
		public void UpdateUserStatus(User user, string status)
		{
			//_context.Users.Attach(user);
			//_context.Entry(user).Property(x => x.status).IsModified = true;
			//_context.SaveChanges();
		}
	}

}
