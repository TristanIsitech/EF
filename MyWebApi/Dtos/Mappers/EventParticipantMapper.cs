using MyWebApi.Models;
using MyWebApi.Dtos;

namespace MyWebApi.Mappers;

public static class EventParticipantMapper
{
    public static EventParticipantDto ToDto(this EventParticipant eventParticipant)
    {
        return new EventParticipantDto
        {
            EventId = eventParticipant.EventId,
            ParticipantId = eventParticipant.ParticipantId,
            RegistrationDate = eventParticipant.RegistrationDate,
            AttendanceStatus = eventParticipant.AttendanceStatus
        };
    }

    public static EventParticipant ToEntity(this EventParticipantRequestDto request)
    {
        return new EventParticipant
        {
            EventId = request.EventId,
            ParticipantId = request.ParticipantId,
            RegistrationDate = request.RegistrationDate,
            AttendanceStatus = request.AttendanceStatus
        };
    }
}
