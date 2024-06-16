using static IIS.API.Presentation.Common.Models.Specialist.SpecialistDTO;

namespace IIS.API.Presentation.Common.Models.Specialist;

public class SpecialistDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Patronymic { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public int Gender { get; set; }

    public string Position { get; set; } = string.Empty;

    public List<NestedServiceDTO> Services { get; set; } = [];

    public class NestedServiceDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Cost { get; set; }

        public int Complexity { get; set; }
    }
}
