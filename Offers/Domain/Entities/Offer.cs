using Domain.Enums;

namespace Domain.Entities;

public class Offer
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public OfferStatus Status { get; set; }
    public string? ImageUrl { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }
}