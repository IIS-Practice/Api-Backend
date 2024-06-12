namespace IIS.API.Domain.Entities;
public class Rewiew
{
    public Guid Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateOnly Date {  get; set; }

    public Guid UserId { get; set; }

    public User? User { get; set; }
}
