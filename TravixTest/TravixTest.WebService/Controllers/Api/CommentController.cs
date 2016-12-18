using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Epam.TravixTest.Common.DtoModels;
using TravixTest.ServiceLayer.Services.Implementations;

namespace Epam.TravixTest.WebService.Controllers.Api
{
    [RoutePrefix("api/comments")]
    public class CommentController : ApiController
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        /// <summary>
        /// Get all comments for post id
        /// GET: localhost:49951/api/comments
        /// </summary>
        /// <returns></returns>
        [Route("{postId:int}")]
        public IEnumerable<CommentDto> GetAllCommentsBy(int postId)
        {
            return _commentService.GetAllCommentsBy(postId);
        }

        /// <summary>
        /// Add new post
        /// POST: localhost:49951/api/comments/
        /// </summary>
        [Route("")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddNew(CommentDto model)
        {
            if (!model.PostId.HasValue)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "PostId field is required");
            }

            model.CreatedDate = DateTime.Now;
            model.LastUpdatedDate = DateTime.Now;

            try
            {
                await _commentService.Add(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        /// <summary>
        /// Update post
        /// PUT: localhost:49951/api/comments/
        /// </summary>
        [Route("")]
        [HttpPut]
        public async Task<HttpResponseMessage> UpdatePost(CommentDto model)
        {
            model.LastUpdatedDate = DateTime.Now;
            try
            {
                await _commentService.UpdateComment(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        /// <summary>
        /// Delete post
        /// DELETE: localhost:49951/api/comments/1
        /// </summary>
        [Route("{id:int}")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            try
            {
                await _commentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
