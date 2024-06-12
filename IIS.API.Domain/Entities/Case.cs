﻿namespace IIS.API.Domain.Entities;
public class Case
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal Cost { get; set; }

    public int Complexity { get; set; }

    public List<Service> Services { get; set; } = [];
}
