using MyWebApi.Enums;
using System.ComponentModel.DataAnnotations;
using MyWebApi.Utils.ErrorMessage;
using MyWebApi.Utils.Validation;

namespace MyWebApi.Dtos;

public class EventRequestDto
{
    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    [StringLength(100, ErrorMessage = ErrorMessage.MaxLengthExceeded)]
    public required string Title { get; set; }

    [StringLength(500, ErrorMessage = ErrorMessage.MaxLengthExceeded)]
    public string? Description { get; set; }

    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    [CompareDates("StartDate", ErrorMessage = ErrorMessage.EndDateBeforeStartDate)]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    public EventStatus Status { get; set; }

    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    public EventCategory Category { get; set; }

    [Required(ErrorMessage = ErrorMessage.RequiredField)]
    public Guid LocationId { get; set; }
}
