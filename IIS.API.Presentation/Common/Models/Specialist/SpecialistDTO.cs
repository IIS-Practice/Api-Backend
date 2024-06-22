namespace IIS.API.Presentation.Common.Models.Specialist;

public class SpecialistDTO
{
    required public Guid Id { get; set; }

    required public string Name { get; set; }

    required public string Surname { get; set; }

    required public string Patronymic { get; set; }

    required public string Email { get; set; }

    required public string Description {  get; set; }

    required public string Position { get; set; }

    public string? CvUri { get; set; }

    public string? ImageUrl { get; set; }
}
