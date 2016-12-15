using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Epam.TravixTest.Domain.Models;
using TravixTest.DAL.Repositories;

namespace Epam.TravixTest.WebService.Controllers.Api
{
    [RoutePrefix("api/posts")]
    public class PostController : ApiController
    {
        private readonly PostRepository _postRepository;

        public PostController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET: localhost:19783/api/posts
        [Route("")]
        public IEnumerable<Post> Get()
        {
            var testPost = new Post
            {
                Title = "Test Post",
                Description = "Test Post Description",
                Content = "Test Post Content",
                CreatedDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now
            };

            _postRepository.Add(testPost);

            return _postRepository.GetAll().ToList();
        }
    }
}
