namespace IIS.API.Presentation.Common.Models.Specialist;

public class SpecialistDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Patronymic { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Desscription {  get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;
}
