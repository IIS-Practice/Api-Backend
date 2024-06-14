namespace IIS.API.Presentation.Common.Models.Review;

public class ReviewDTO
{
    required public Guid ReviewId { get; set; }

    required public string Text { get; set; }

    required public DateTime Date { get; set; }

    required public Guid UserId { get; set; }

    required public string FullName { get; set; }
}

