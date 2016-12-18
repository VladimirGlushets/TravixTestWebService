using System;
using System.Linq;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravixTest.UnitTests.Helpers;

namespace TravixTest.UnitTests.Repositories
{
    [TestClass]
    public class PostsRepositoryTest
    {
        private readonly IGenericRepository<Post> _postsMockRepository;

        public PostsRepositoryTest()
        {
            var repo = new PostsMockRepository();
            _postsMockRepository = repo.GetMock().Object;
        }

        [TestMethod]
        public void GetByIdShouldReturnPostById()
        {
            var actual = _postsMockRepository.Get(1);

            Assert.AreEqual("Title 1", actual.Title);
        }

        [TestMethod]
        public void GetAllShouldReturnAllPosts()
        {
            var actual = _postsMockRepository.GetAll();

            Assert.AreEqual(3, actual.Count());
        }

        [TestMethod]
        public void AddPostTest()
        {
            var extented = new Post
            {
                Id = 4,
                Content = "Content 4",
                Title = "Title 4",
                Description = "Description 4",
                CreatedDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now
            };

            _postsMockRepository.Add(extented);

            var actual = _postsMockRepository.Get(extented.Id);

            Assert.AreEqual(extented, actual);
        }

        [TestMethod]
        public void UpdatePostTest()
        {
            var extented = new Post
            {
                Id = 3,
                Content = "Updated",
                Title = "Updated",
                Description = "Updated",
                LastUpdatedDate = DateTime.Now
            };

            _postsMockRepository.Update(extented);

            var actual = _postsMockRepository.Get(extented.Id);

            Assert.AreEqual("Updated", actual.Content);
        }

        [TestMethod]
        public void RemovePostTest()
        {
            var extented = _postsMockRepository.Get(1);

            _postsMockRepository.Delete(extented);

            var actual = _postsMockRepository.Get(extented.Id);

            Assert.AreEqual(null, actual);
        }
    }
}
