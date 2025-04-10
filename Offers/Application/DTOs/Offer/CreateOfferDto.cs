namespace Application.DTOs.Offer;

public class CreateOfferDto
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public int DurationInMinutes { get; set; }
    public string? ImageUrl { get; set; }
    public Guid CategoryId { get; set; }
}