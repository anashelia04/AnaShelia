using Application.DTOs.Offer;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OffersController : ControllerBase
{
    private readonly IOfferService _offerService;

    public OffersController(IOfferService offerService)
    {
        _offerService = offerService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OfferDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetActiveOffers(CancellationToken cancellationToken)
    {
        var offers = await _offerService.GetActiveOffersAsync(cancellationToken);
        return Ok(offers);
    }

    // GET /api/v1offers/{id}
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(OfferDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetOffer(Guid id, CancellationToken cancellationToken)
    {
        var offer = await _offerService.GetOfferByIdAsync(id, cancellationToken);
        return offer == null ? NotFound() : Ok(offer);
    }


    [HttpPost]
    [ProducesResponseType(typeof(OfferDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> CreateOffer([FromBody] CreateOfferDto createDto,
        CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var createdOffer = await _offerService.CreateOfferAsync(createDto, cancellationToken);
            return CreatedAtAction(nameof(GetOffer), new { id = createdOffer.Id }, createdOffer);
        }
        catch (KeyNotFoundException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> UpdateOffer(Guid id, [FromBody] UpdateOfferDto updateDto,
        CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await _offerService.UpdateOfferAsync(id, updateDto, cancellationToken);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost("{id:guid}/cancel")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> CancelOffer(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            await _offerService.CancelOfferAsync(id, cancellationToken);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid();
        }
    }
}