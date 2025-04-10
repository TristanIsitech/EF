using MyWebApi.Enums;
using System.ComponentModel.DataAnnotations;
using MyWebApi.Utils.ErrorMessage;
using MyWebApi.Utils.Validation;

namespace MyWebApi.Dtos;

public class EventRequestDto
{
    [Required(ErrorMessage = MessageError.RequiredField)]
    [StringLength(100, ErrorMessage = MessageError.MaxLengthExceeded)]
    public required string Title { get; set; }

    [StringLength(500, ErrorMessage = MessageError.MaxLengthExceeded)]
    public string? Description { get; set; }

    [Required(ErrorMessage = MessageError.RequiredField)]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = MessageError.RequiredField)]
    [CompareDates("StartDate", ErrorMessage = MessageError.EndDateBeforeStartDate)]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = MessageError.RequiredField)]
    public EventStatus Status { get; set; }

    [Required(ErrorMessage = MessageError.RequiredField)]
    public EventCategory Category { get; set; }

    [Required(ErrorMessage = MessageError.RequiredField)]
    public Guid LocationId { get; set; }
}
