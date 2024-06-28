namespace IIS.API.Presentation.Common.Models.Case;

public class CaseDTO
{
    required public Guid Id { get; set; }

    required public string Name { get; set; }

    required public string ShortDescription { get; set; }

    required public string InnerHtml { get; set; }

    required public DateTime StartDate { get; set; }

    required public DateTime EndDate { get; set; }

    required public decimal Cost { get; set; }

    required public int Complexity { get; set; }

    public List<string> Images { get; set; } = [];

    public List<InnerServiceDTO> Services { get; set; } = [];

    public class InnerServiceDTO
    {
        required public Guid Id { get; set; }

        required public string Name { get; set; }
    }

}
