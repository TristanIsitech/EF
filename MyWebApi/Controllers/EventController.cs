using Microsoft.AspNetCore.Mvc;
using MyWebApi.Services;
using MyWebApi.Dtos;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;

    public EventController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateEvent([FromBody] EventRequestDto request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdEvent = await _eventService.CreateEventAsync(request);
        return CreatedAtAction(nameof(GetEventById), new { id = createdEvent.Id }, createdEvent);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateEvent(Guid id, [FromBody] EventRequestDto request)
    {
        var updatedEvent = await _eventService.UpdateEventAsync(id, request);
        if (updatedEvent == null) return NotFound();
        return Ok(updatedEvent);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteEvent(Guid id)
    {
        var success = await _eventService.DeleteEventAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetEventById(Guid id)
    {
        var eventDto = await _eventService.GetEventByIdAsync(id);
        if (eventDto == null)
            return NotFound();

        return Ok(eventDto);
    }
}
