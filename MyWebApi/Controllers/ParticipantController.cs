using Microsoft.AspNetCore.Mvc;
using MyWebApi.Services;
using MyWebApi.Dtos;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParticipantController : ControllerBase
{
    private readonly IParticipantService _participantService;

    public ParticipantController(IParticipantService participantService)
    {
        _participantService = participantService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateParticipant([FromBody] ParticipantRequestDto request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdParticipant = await _participantService.CreateParticipantAsync(request);
        return CreatedAtAction(nameof(GetParticipantById), new { id = createdParticipant.Id }, createdParticipant);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateParticipant(Guid id, [FromBody] ParticipantRequestDto request)
    {
        var updatedParticipant = await _participantService.UpdateParticipantAsync(id, request);
        if (updatedParticipant == null) return NotFound();
        return Ok(updatedParticipant);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteParticipant(Guid id)
    {
        var success = await _participantService.DeleteParticipantAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetParticipantById(Guid id)
    {
        var participantDto = await _participantService.GetParticipantByIdAsync(id);
        if (participantDto == null)
            return NotFound();

        return Ok(participantDto);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllParticipants()
    {
        var participants = await _participantService.GetAllParticipantsAsync();
        return Ok(participants);
    }

    [HttpGet("{id:guid}/events")]
    public async Task<IActionResult> GetParticipantEvents(Guid id)
    {
        var events = await _participantService.GetParticipantEventsAsync(id);
        if (events == null || !events.Any())
            return NotFound();

        return Ok(events);
    }
}
