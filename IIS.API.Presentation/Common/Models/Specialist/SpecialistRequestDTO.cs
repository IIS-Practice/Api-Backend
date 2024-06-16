namespace IIS.API.Presentation.Common.Models.Specialist;

public class SpecialistRequestDTO
{
    required public string Name { get; set; }

    required public string Surname { get; set; }

    required public string Patronymic { get; set; }

    required public string Email { get; set; }

    required public string Password { get; set; }

    required public string PhoneNumber { get; set; }

    required public string Country { get; set; }

    required public string City { get; set; }

    required public DateTime DateOfBirth { get; set; }

    required public int Gender { get; set; }

    required public string Position { get; set; }
}
