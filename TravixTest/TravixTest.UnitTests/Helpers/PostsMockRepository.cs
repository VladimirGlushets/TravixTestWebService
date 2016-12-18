using System;
using System.Collections.Generic;
using System.Linq;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Moq;

namespace TravixTest.UnitTests.Helpers
{
    public class PostsMockRepository
    {
        private List<Post> _postsInMemoryDatabase;

        public PostsMockRepository()
        {
            InitPostsInMemoryDatabase();
        }

        /// <summary>
        /// returt cogfigured mock posts repository
        /// </summary>
        /// <returns></returns>
        public Mock<IGenericRepository<Post>> GetMock()
        {
            var mockObj = new Mock<IGenericRepository<Post>>();

            mockObj.Setup(x => x.Get(It.IsAny<int>()))
                .Returns((int i) => _postsInMemoryDatabase.FirstOrDefault(p => p.Id == i));

            mockObj.Setup(x => x.GetAll())
                .Returns(() => _postsInMemoryDatabase);

            mockObj.Setup(x => x.Add(It.IsAny<Post>()))
                .Callback((Post post) => { _postsInMemoryDatabase.Add(post); }).Verifiable();

            mockObj.Setup(x => x.Delete(It.IsAny<Post>()))
                .Callback((Post post) => { _postsInMemoryDatabase.Remove(post); }).Verifiable();

            mockObj.Setup(x => x.Update(It.IsAny<Post>()))
                .Callback((Post post) =>
                {
                    var existsPost = _postsInMemoryDatabase.Single(x => x.Id == post.Id);

                    _postsInMemoryDatabase.Remove(existsPost);

                    existsPost.Title = post.Title;
                    existsPost.Description = post.Description;
                    existsPost.Content = post.Content;
                    existsPost.LastUpdatedDate = post.LastUpdatedDate;

                    _postsInMemoryDatabase.Add(existsPost);
                }).Verifiable();


            return mockObj;
        }

        /// <summary>
        /// Init posts database in memory
        /// </summary>
        private void InitPostsInMemoryDatabase()
        {
            _postsInMemoryDatabase = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Title 1",
                    Description = "Description 1",
                    Content = "Content",
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                    Comments = FillCommentsList(1)
                },
                new Post
                {
                    Id = 2,
                    Title = "Title 2",
                    Description = "Description 2",
                    Content = "Content",
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                    Comments = FillCommentsList(2)
                },
                new Post
                {
                    Id = 3,
                    Title = "Title 3",
                    Description = "Description 3",
                    Content = "Content",
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                    Comments = FillCommentsList(3)
                }
            };
        }

        /// <summary>
        /// Return list of comments for current postId
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        private List<Comment> FillCommentsList(int postId)
        {
            return new List<Comment>
            {
                new Comment
                        {
                            Id = postId,
                            Content = "Content 1",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = postId
                        },
                new Comment
                        {
                            Id = postId,
                            Content = "Content 2",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = postId
                        },
                new Comment
                        {
                            Id = postId,
                            Content = "Content 3",
                            CreatedDate = DateTime.Now,
                            LastUpdatedDate = DateTime.Now,
                            PostId = postId
                        }
            };
        }
    }
}
