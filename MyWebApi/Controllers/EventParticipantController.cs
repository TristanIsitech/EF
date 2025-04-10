using Microsoft.AspNetCore.Mvc;
using MyWebApi.Services;
using MyWebApi.Dtos;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventParticipantController : ControllerBase
{
    private readonly IEventParticipantService _eventParticipantService;

    public EventParticipantController(IEventParticipantService eventParticipantService)
    {
        _eventParticipantService = eventParticipantService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateEventParticipant([FromBody] EventParticipantRequestDto request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdEventParticipant = await _eventParticipantService.CreateEventParticipantAsync(request);
        return CreatedAtAction(nameof(GetEventParticipantById), new { eventId = createdEventParticipant.EventId, participantId = createdEventParticipant.ParticipantId }, createdEventParticipant);
    }

    [HttpPut("{eventId:guid}/{participantId:guid}")]
    public async Task<IActionResult> UpdateEventParticipant(Guid eventId, Guid participantId, [FromBody] EventParticipantRequestDto request)
    {
        var updatedEventParticipant = await _eventParticipantService.UpdateEventParticipantAsync(eventId, participantId, request);
        if (updatedEventParticipant == null) return NotFound();
        return Ok(updatedEventParticipant);
    }

    [HttpDelete("{eventId:guid}/{participantId:guid}")]
    public async Task<IActionResult> DeleteEventParticipant(Guid eventId, Guid participantId)
    {
        var success = await _eventParticipantService.DeleteEventParticipantAsync(eventId, participantId);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpGet("{eventId:guid}/{participantId:guid}")]
    public async Task<IActionResult> GetEventParticipantById(Guid eventId, Guid participantId)
    {
        var eventParticipantDto = await _eventParticipantService.GetEventParticipantByIdAsync(eventId, participantId);
        if (eventParticipantDto == null)
            return NotFound();

        return Ok(eventParticipantDto);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllEventParticipants()
    {
        var eventParticipants = await _eventParticipantService.GetAllEventParticipantsAsync();
        return Ok(eventParticipants);
    }
}
