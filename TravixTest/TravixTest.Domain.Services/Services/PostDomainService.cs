using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Epam.TravixTest.Domain.Services.Interfaces.Interfaces;

namespace TravixTest.Domain.Services.Services
{
    public class PostDomainService : GenericDomainService<Post, PostBuisnessModel>, IPostDomainService
    {
        public PostDomainService(IPostRepository repository) : base(repository)
        {
        }
    }
}
