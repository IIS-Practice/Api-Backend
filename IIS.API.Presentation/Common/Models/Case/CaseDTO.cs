using IIS.API.Presentation.Common.Models.Review;

namespace IIS.API.Presentation.Common.Models.Case;

public class CaseDTO
{
    required public Guid Id { get; set; }

    required public string Name { get; set; }

    required public string Description { get; set; }

    required public DateTime StartDate { get; set; }

    required public DateTime EndDate { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }

    public List<ReviewDTO> Reviews { get; set; } = [];
}
