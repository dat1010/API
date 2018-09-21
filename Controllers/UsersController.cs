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
	[Route("api/v1/users")]
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


		[HttpGet("{id}/verifications")]
		public async Task<UserResource> Get(int id)
		{
			var user = await _context.Users.FindAsync(id);
			var userResource = _mapper.Map<User, UserResource>(user);
			return userResource;
		}

		[HttpPost]
		public async Task<IActionResult> CreateUser([FromBody] User user) 
		{
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
			return Ok(user);
		}
	}					
}
