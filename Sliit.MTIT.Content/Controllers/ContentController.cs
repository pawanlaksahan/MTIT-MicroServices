using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Content.Data;
using Sliit.MTIT.Content.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Content.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            _contentService = contentService?? throw new ArgumentNullException(nameof(contentService));
        }


        /// <summary>
        /// Get all contents
        /// </summary>
        /// <returns>return the list of contents</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contentService.GetContents());
        }

        /// <summary>
        /// Get Content by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Content with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _contentService.GetContent(id) != null ? Ok(_contentService.GetContent(id)) : NoContent();
        }

        /// <summary>
        /// Add contents
        /// </summary>
        /// <param name="Content"></param>
        /// <returns>Return the added Content</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Content content)
        {
            return Ok(_contentService.AddContent(content));
        }

        /// <summary>
        /// Update the Content
        /// </summary>
        /// <param name="Content"></param>
        /// <returns>Return the updated Content</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Content content)
        {
            return Ok(_contentService.UpdateContent(content));
        }

        /// <summary>
        /// Delete the Content with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _contentService.DeleteContent(id);

            return result.HasValue & result == true ? Ok($"Content with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Content with ID:{id}.");
        }
    }
}
