namespace IIS.API.Domain.Entities;
public class Specialist : User
{
    public string Position { get; set; } = string.Empty;

    public string Description {  get; set; } = string.Empty;

    public List<Service> Services { get; set; } = [];
}
