namespace IIS.API.Presentation.Common.Models.Service;

public class ServiceRequestDTO
{
    required public string Name { get; set; }

    required public string Description { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }
}
