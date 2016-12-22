using AutoMapper;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Buisness.Models.DtoModels;
using Epam.TravixTest.Domain.Models;

namespace Epam.TravixTest.Infrastructure.AutoMapper
{
    /// <summary>
    /// Includes all mapping rules for Comment entity
    /// </summary>
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentBuisnessModel>()
                .ForMember(x => x.Id, y => y.MapFrom(c => c.Id))
                .ForMember(x => x.Content, y => y.MapFrom(c => c.Content))
                .ForMember(x => x.CreatedDate, y => y.MapFrom(c => c.CreatedDate))
                .ForMember(x => x.LastUpdatedDate, y => y.MapFrom(c => c.LastUpdatedDate))
                .ForMember(x => x.PostId, y => y.MapFrom(c => c.PostId))
                .ReverseMap();

            CreateMap<CommentBuisnessModel, CommentDto>()
                .ForMember(x => x.Id, y => y.MapFrom(c => c.Id))
                .ForMember(x => x.Content, y => y.MapFrom(c => c.Content))
                .ForMember(x => x.CreatedDate, y => y.MapFrom(c => c.CreatedDate))
                .ForMember(x => x.LastUpdatedDate, y => y.MapFrom(c => c.LastUpdatedDate))
                .ForMember(x => x.PostId, y => y.MapFrom(c => c.PostId))
                .ReverseMap();
        }
    }
}
