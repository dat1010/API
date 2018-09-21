namespace API.Models
{
	public class Comment
		{
			public int id {get; set;}
			public string comment {get; set;}
			public int user_id {get; set;}
			public int post_id {get; set;}
		}
	}
