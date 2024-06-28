namespace IIS.API.Presentation.Common.Models.Case;

public class CaseRequestDTO
{
    required public string Name { get; set; }

    required public string ShortDescription { get; set; }

    required public string InnerHtml { get; set; }

    required public DateTime StartDate { get; set; }

    required public DateTime EndDate { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }
}
