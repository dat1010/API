using TradehoundsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using AutoMapper;
using API.Persistence;
using API.Controllers.Resource;
using BCrypt;

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

		[HttpPost("{id}/verifications")]
		public async Task<IActionResult> CreateUser([FromBody] VerificationResource verification, int id)
        {
            var user = await _context.Users.FindAsync(id);
            bool pinVerified = NewMethod(verification, user);

            if (!pinVerified)
            {
                //TODO return 401
                return null;
            }
            else
            {
                return Ok(CreateWithValidPin(user));
            }
        }

	
        private static bool NewMethod(VerificationResource verification, User user) => BCrypt.Net.BCrypt.Verify(verification.attributes.Pin, user.hashed_verification_pin);

        public VerificationResource CreateWithValidPin(User user)
		{	
			var vr = new VerificationResource();
			var account = new Accounts(_context);
			account.UpdateUserStatus(user, "authenticated");
			vr.Type = "verifications";
			vr.attributes = new API.Controllers.Resource.Attribute();
			vr.attributes.user_id = user.Id;
			vr.attributes.jwt = "fake_jwt";
			return vr;
		}
		
	}					
}
