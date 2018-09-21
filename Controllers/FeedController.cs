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

namespace Controllers.FeedController
{	
	[Route("api/v1/users")]
	[ApiController]
	public class FeedController : ControllerBase
	{

		private ApiContext _context;
		public FeedController(ApiContext context)
		{
			_context = context;
		}

		[HttpGet("{id}/feeds")]
		public  IQueryable<Post> Get(int id)
		{
			var posts =  _context.Posts.OrderByDescending(p => p.inserted_at);
			return posts;
		}
	}
}
