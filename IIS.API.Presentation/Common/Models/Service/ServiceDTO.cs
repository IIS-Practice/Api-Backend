namespace IIS.API.Presentation.Common.Models.Service;

public class ServiceDTO
{
    required public Guid Id { get; set; }

    required public string Name { get; set; }

    required public string Description { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }

    public List<InnerSpecialistDTO> Specialists { get; set; } = [];

    public List<InnerCaseDTO> Cases { get; set; } = [];


    public class InnerSpecialistDTO
    {
        required public Guid Id { get; set; }

        required public string FullName { get; set; }
    }

    public class InnerCaseDTO
    {
        required public Guid Id { get; set; }

        required public string Name { get; set; }
    }
}
