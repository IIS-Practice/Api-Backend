namespace IIS.API.Domain.Entities;

public class Review
{
    public Guid Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime Date {  get; set; }

    public Guid UserId { get; set; }

    public User? User { get; set; }
}
