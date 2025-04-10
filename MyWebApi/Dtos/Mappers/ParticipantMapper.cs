using MyWebApi.Models;
using MyWebApi.Dtos;

namespace MyWebApi.Mappers;

public static class ParticipantMapper
{
    public static ParticipantDto ToDto(this Participant participant)
    {
        return new ParticipantDto
        {
            Id = participant.Id,
            FirstName = participant.FirstName,
            LastName = participant.LastName,
            Email = participant.Email,
            Company = participant.Company,
            JobTitle = participant.JobTitle
        };
    }

    public static Participant ToEntity(this ParticipantRequestDto request)
    {
        return new Participant
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Company = request.Company,
            JobTitle = request.JobTitle
        };
    }
}
