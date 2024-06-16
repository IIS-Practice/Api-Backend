using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Domain.Entities;
public class Application
{
    public Guid Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string NormalizedEmail { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public DateTime Date { get; set; }
}
