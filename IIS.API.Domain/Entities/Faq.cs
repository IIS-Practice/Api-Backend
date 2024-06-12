namespace IIS.API.Domain.Entities;

public class Faq
{
    public Guid Id { get; set; }

    public string Question { get; set; } = string.Empty;

    public string Answer { get; set; } = string.Empty;
}
