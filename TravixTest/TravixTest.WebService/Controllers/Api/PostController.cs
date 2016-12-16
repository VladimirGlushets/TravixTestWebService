using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Epam.TravixTest.Common.DtoModels;
using TravixTest.ServiceLayer.Managers.Implementations;

namespace Epam.TravixTest.WebService.Controllers.Api
{
    [RoutePrefix("api/posts")]
    public class PostController : ApiController
    {
        private readonly PostManager _postManager;

        public PostController(PostManager postManager)
        {
            _postManager = postManager;
        }

        /// <summary>
        /// Get all posts
        /// GET: localhost:49951/api/posts
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public IEnumerable<PostDto> GetAll()
        {
            return _postManager.GetAll();
        }

        /// <summary>
        /// Get post by id
        /// GET: localhost:49951/api/posts/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}")]
        public PostDto Get(int id)
        {
            return _postManager.Get(id);
        }

        /// <summary>
        /// Add new post
        /// POST: localhost:49951/api/posts/
        /// </summary>
        [Route("")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddNew(PostDto model)
        {
            model.CreatedDate = DateTime.Now;
            model.LastUpdatedDate = DateTime.Now;

            try
            {
                await _postManager.Add(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        /// <summary>
        /// Update post
        /// PUT: localhost:49951/api/posts/
        /// </summary>
        [Route("")]
        [HttpPut]
        public async Task<HttpResponseMessage> UpdatePost(PostDto model)
        {
            model.LastUpdatedDate = DateTime.Now;
            try
            {
                await _postManager.Update(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        /// <summary>
        /// Delete post
        /// DELETE: localhost:49951/api/posts/1
        /// </summary>
        [Route("{id:int}")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            try
            {
                await _postManager.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
