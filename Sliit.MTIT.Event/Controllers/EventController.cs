using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Event.Data;
using Sliit.MTIT.Event.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Event.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
        }


        /// <summary>
        /// Get all events
        /// </summary>
        /// <returns>return the list of events</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventService.GetEvents());
        }

        /// <summary>
        /// Get Event by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Event with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _eventService.GetEvent(id) != null ? Ok(_eventService.GetEvent(id)) : NoContent();
        }

        /// <summary>
        /// Add events
        /// </summary>
        /// <param name="Event"></param>
        /// <returns>Return the added Event</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Event events)
        {
            return Ok(_eventService.AddEvent(events));
        }

        /// <summary>
        /// Update the Event
        /// </summary>
        /// <param name="Event"></param>
        /// <returns>Return the updated Event</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Event events )
        {
            return Ok(_eventService.UpdateEvent(events));
        }

        /// <summary>
        /// Delete the Event with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _eventService.DeleteEvent(id);

            return result.HasValue & result == true ? Ok($"Event with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Event with ID:{id}.");
        }
    }
}
