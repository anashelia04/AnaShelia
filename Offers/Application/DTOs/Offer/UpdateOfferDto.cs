namespace Application.DTOs.Offer;

public class UpdateOfferDto
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string? ImageUrl { get; set; }
}