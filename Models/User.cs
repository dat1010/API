namespace API.Models
{
	public class User
	{
		public int Id {get; set;}
		public string Name {get; set;}
		public string Email {get; set;}
		public string phone {get; set;}
		public string location {get; set;}
		public string photo_url {get; set;}
		public string role {get; set;}
		public string status {get; set;}
		public string birth_year {get; set;}
		public int verification_pin_timeout {get; set;}
		public string hashed_verification_pin {get; set;}
	}
}
