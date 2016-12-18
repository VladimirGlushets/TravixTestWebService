using System;
using System.Collections.Generic;
using System.Linq;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Moq;

namespace TravixTest.UnitTests.Helpers
{
    public class CommentsMockRepository
    {
        private List<Comment> _commentsInMemoryDatabase;

        public CommentsMockRepository()
        {
            InitCommentsInMemoryDatabase();
        }

        /// <summary>
        /// returt cogfigured mock comments repository
        /// </summary>
        /// <returns></returns>
        public Mock<IGenericRepository<Comment>> GetMock()
        {
            var mockObj = new Mock<IGenericRepository<Comment>>();

            mockObj.Setup(x => x.Get(It.IsAny<int>()))
                .Returns((int i) => _commentsInMemoryDatabase.FirstOrDefault(p => p.Id == i));

            mockObj.Setup(x => x.GetAll())
                .Returns(() => _commentsInMemoryDatabase);

            mockObj.Setup(x => x.Add(It.IsAny<Comment>()))
                .Callback((Comment comment) => { _commentsInMemoryDatabase.Add(comment); }).Verifiable();

            mockObj.Setup(x => x.Delete(It.IsAny<Comment>()))
                .Callback((Comment comment) => { _commentsInMemoryDatabase.Remove(comment); }).Verifiable();

            mockObj.Setup(x => x.Update(It.IsAny<Comment>()))
                .Callback((Comment comment) =>
                {
                    var exists = _commentsInMemoryDatabase.Single(x => x.Id == comment.Id);

                    _commentsInMemoryDatabase.Remove(exists);

                    exists.Content = comment.Content;
                    exists.LastUpdatedDate = comment.LastUpdatedDate;

                    _commentsInMemoryDatabase.Add(exists);
                }).Verifiable();


            return mockObj;
        }

        /// <summary>
        /// Init comments database in memory
        /// </summary>
        private void InitCommentsInMemoryDatabase()
        {
            _commentsInMemoryDatabase = new List<Comment>
            {
                new Comment
                        {
                            Id = 1,
                            Content = "Content 1",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = 1
                        },
                new Comment
                        {
                            Id = 2,
                            Content = "Content 2",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = 1
                        },
                new Comment
                        {
                            Id = 3,
                            Content = "Content 3",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = 1
                        }
            };
        }
    }
}
