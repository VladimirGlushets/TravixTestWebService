using System;
using System.Linq;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravixTest.UnitTests.Helpers;

namespace TravixTest.UnitTests.Repositories
{
    [TestClass]
    public class CommentsRepositoryTest
    {
        private IGenericRepository<Comment> _commentsMockRepository;

        public CommentsRepositoryTest()
        {
            var repo = new CommentsMockRepository();
            _commentsMockRepository = repo.GetMock().Object;
        }

        [TestMethod]
        public void GetByIdShouldReturnCommentById()
        {
            var actual = _commentsMockRepository.Get(1);

            Assert.AreEqual("Content 1", actual.Content);
        }

        [TestMethod]
        public void GetAllShouldReturnAllComments()
        {
            var actual = _commentsMockRepository.GetAll();

            Assert.AreEqual(3, actual.Count());
        }

        [TestMethod]
        public void AddCommentTest()
        {
            var extented = new Comment
            {
                Id = 4,
                Content = "Content 4",
                CreatedDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now
            };

            _commentsMockRepository.Add(extented);

            var actual = _commentsMockRepository.Get(extented.Id);

            Assert.AreEqual(extented, actual);
        }

        [TestMethod]
        public void UpdateCommentTest()
        {
            var extented = new Comment
            {
                Id = 3,
                Content = "Updated",
                LastUpdatedDate = DateTime.Now
            };

            _commentsMockRepository.Update(extented);

            var actual = _commentsMockRepository.Get(extented.Id);

            Assert.AreEqual("Updated", actual.Content);
        }

        [TestMethod]
        public void RemoveCommentTest()
        {
            var extented = _commentsMockRepository.Get(1);

            _commentsMockRepository.Delete(extented);

            var actual = _commentsMockRepository.Get(extented.Id);

            Assert.AreEqual(null, actual);
        }
    }
}
