using AutoMapper;
using User.Domain;

namespace User.API.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.User, UserResponse>();
            CreateMap<UserRequest, Domain.User>();
        }
    }
}
