namespace API.Models
{
	public class Reaction
	{
		public int id {get; set;}
		public string type {get; set;}
		public int user_id {get; set;}
		public int post_id {get; set;}
	}
}
