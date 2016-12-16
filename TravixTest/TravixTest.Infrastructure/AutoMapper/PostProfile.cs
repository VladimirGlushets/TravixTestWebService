using AutoMapper;
using Epam.TravixTest.Common.DtoModels;
using Epam.TravixTest.Domain.Models;

namespace Epam.TravixTest.Infrastructure.AutoMapper
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDto>()
                .ForMember(x => x.Id, y => y.MapFrom(c => c.Id))
                .ForMember(x => x.Title, y => y.MapFrom(c => c.Title))
                .ForMember(x => x.Description, y => y.MapFrom(c => c.Description))
                .ForMember(x => x.Content, y => y.MapFrom(c => c.Content))
                .ForMember(x => x.CreatedDate, y => y.MapFrom(c => c.CreatedDate))
                .ForMember(x => x.LastUpdatedDate, y => y.MapFrom(c => c.LastUpdatedDate))
                .ForMember(x => x.Comments, y => y.MapFrom(c => c.Comments))
                .ReverseMap();
        }

    }
}
