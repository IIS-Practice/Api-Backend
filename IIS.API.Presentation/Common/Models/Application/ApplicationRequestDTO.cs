namespace IIS.API.Presentation.Common.Models.Application;

public class ApplicationRequestDTO
{
    required public string Description { get; set; }

    required public string Author { get; set; }

    required public string Email { get; set; }

    required public string PhoneNumber { get; set; }
}
