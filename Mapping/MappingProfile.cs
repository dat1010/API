using API.Models;
using API.Controllers.Resource;
using AutoMapper;


namespace API.Mapping
{	
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<User, UserResource>();	
			CreateMap<UserResource, User>();	
		}
	}
}
