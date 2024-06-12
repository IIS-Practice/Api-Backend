namespace IIS.API.Domain.Entities;
public class User
{
    Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Patronymic {  get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string NormalizedEmail {  get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public DateOnly DateOfBirth { get; set; }

    public int Gender { get; set; }
}
