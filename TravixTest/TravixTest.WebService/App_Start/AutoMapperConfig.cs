using AutoMapper;
using Epam.TravixTest.Infrastructure.AutoMapper;

namespace Epam.TravixTest.WebService
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<PostProfile>();
                cfg.AddProfile<CommentProfile>();
            });
        }
    }
}