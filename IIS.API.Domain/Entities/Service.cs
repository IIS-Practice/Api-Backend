namespace IIS.API.Domain.Entities;
public class Service
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Cost { get; set; }

    public int Complexity { get; set; }

    public List<Specialist> Specialists { get; set; } = [];
}
