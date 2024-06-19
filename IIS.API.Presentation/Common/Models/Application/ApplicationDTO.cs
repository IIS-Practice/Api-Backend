namespace IIS.API.Presentation.Common.Models.Application;

public class ApplicationDTO
{
    required public Guid Id { get; set; }

    required public string Description { get; set; }

    required public string Author { get; set; }

    required public string Email { get; set; }

    required public string PhoneNumber { get; set; }

    required public DateTime Date { get; set; }
}
