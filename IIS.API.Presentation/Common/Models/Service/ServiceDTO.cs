namespace IIS.API.Presentation.Common.Models.Service;

public class ServiceDTO
{
    required public Guid Id { get; set; }

    required public string Name { get; set; }

    required public string Description { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }
}
