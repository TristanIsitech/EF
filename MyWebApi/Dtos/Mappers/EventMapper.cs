using MyWebApi.Dtos;
using MyWebApi.Models;

namespace MyWebApi.Dtos;

public static class EventMapper
{
    public static Event ToModel(EventRequestDto requestDto)
    {
        return new Event
        {
            Title = requestDto.Title,
            Description = requestDto.Description,
            StartDate = requestDto.StartDate,
            EndDate = requestDto.EndDate,
            Status = requestDto.Status,
            Category = requestDto.Category,
            LocationId = requestDto.LocationId
        };
    }

    public static EventDto ToDto(Event model)
    {
        return new EventDto
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
            StartDate = model.StartDate,
            EndDate = model.EndDate,
            Status = model.Status,
            Category = model.Category,
            LocationId = model.LocationId,
            Location = model.Location != null ? LocationMapper.ToDto(model.Location) : null
        };
    }

    public static Event ToModel(EventDto dto)
    {
        return new Event
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            Status = dto.Status,
            Category = dto.Category,
            LocationId = dto.LocationId
        };
    }

    //public static EventResponseDto ToResponseDto(Event model)
    //{
    //    return new EventResponseDto
    //    {
    //        Id = model.Id,
    //        Title = model.Title,
    //        Description = model.Description,
    //        StartDate = model.StartDate,
    //        EndDate = model.EndDate,
    //        Status = model.Status,
    //        Category = model.Category,
    //        LocationId = model.LocationId,
    //        LocationName = model.Location?.Name ?? string.Empty
    //    };
    //}
}
