namespace API.Models
{
	public class Photo
	{
		public int id {get; set;}
		public float latitude {get; set;}
		public float longitude {get; set;}
		public string location {get; set;}
		public string raw_url {get; set;}
		public string feed_url {get; set;}
		public string watermarked_url {get; set;}
		public string open_graph_url {get; set;}
		public string encoded_photo {get; set;}
		public int post_id {get; set;}
	}
}
