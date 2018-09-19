using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using AutoMapper;
using API.Persistence;
using API.Controllers.Resource;

namespace Controllers.UsersController
{	
	[Route("api/users")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private ApiContext _context;
		
		public UsersController(IMapper mapper, ApiContext context)
		{
			_mapper = mapper;
			_context = context;
		}
		[HttpGet]
		public ActionResult<User> Get()
		{
			return new User();
		}

/*   [HttpPost]
    0     public async Task<IActionResult> CreatePost([FromBody] Models.Post post)
    1     {
    2       context.Posts.Add(post);
    3       await context.SaveChangesAsync();
    4       return Ok(post);
    5     }
*/

		[HttpGet("{id}")]
		public async Task<UserResource> Get(int id)
		{
			var user = await _context.Users.FindAsync(id);
			var userResource = _mapper.Map<User, UserResource>(user);
			return userResource;
		}

		[HttpPost]
		public async Task<IActionResult> CreateUser([FromBody] Users user) 
		{
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
			return Ok(user);
		}
	}					
}
