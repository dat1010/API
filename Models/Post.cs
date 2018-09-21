using System;

namespace API.Models
{
	public class Post
	{
		public int id {get; set;}
		public bool in_my_work {get; set;}
		public int user_id {get; set;}
		public int job_site_id {get; set;}
		public DateTime inserted_at {get; set;}
	}
}
