using Microsoft.AspNetCore.Mvc;
using MyWebApi.Dtos;
using MyWebApi.Services;

namespace MyWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateLocation([FromBody] LocationRequestDto request)
    {
        var createdLocation = await _locationService.CreateLocationAsync(request);
        return CreatedAtAction(nameof(GetLocationById), new { id = createdLocation.Id }, createdLocation);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateLocation(Guid id, [FromBody] LocationRequestDto request)
    {
        var updatedLocation = await _locationService.UpdateLocationAsync(id, request);
        if (updatedLocation == null) return NotFound();
        return Ok(updatedLocation);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteLocation(Guid id)
    {
        var success = await _locationService.DeleteLocationAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllLocations()
    {
        var locations = await _locationService.GetAllLocationsAsync();
        return Ok(locations);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetLocationById(Guid id)
    {
        var location = await _locationService.GetLocationByIdAsync(id);
        if (location == null) return NotFound();
        return Ok(location);
    }

    [HttpGet("by-name/{name}")]
    public async Task<IActionResult> GetLocationByName(string name)
    {
        var location = await _locationService.GetLocationByNameAsync(name);
        if (location == null) return NotFound();
        return Ok(location);
    }
}
