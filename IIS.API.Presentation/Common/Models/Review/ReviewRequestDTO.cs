namespace IIS.API.Presentation.Common.Models.Review;

public class ReviewRequestDTO
{
    required public string Text { get; set; }

    required public Guid UserId { get; set; }
}

