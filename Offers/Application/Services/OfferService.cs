using Application.DTOs.Offer;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services;

public class OfferService : IOfferService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public OfferService(
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<OfferDto>> GetAllOffersAsync(CancellationToken cancellationToken = default)
    {
        var offers = await _unitOfWork.Offers.GetAllAsync(cancellationToken);
        return _mapper.Map<IEnumerable<OfferDto>>(offers);
    }

    public async Task<IEnumerable<OfferDto>> GetActiveOffersAsync(CancellationToken cancellationToken = default)
    {
        var activeOffers = await _unitOfWork.Offers.GetActiveOffersAsync(cancellationToken);
        return _mapper.Map<IEnumerable<OfferDto>>(activeOffers);
    }

    public async Task<OfferDto?> GetOfferByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var offer = await _unitOfWork.Offers.GetByIdAsync(id, cancellationToken);
        return offer != null ? _mapper.Map<OfferDto>(offer) : null;
    }

    public async Task<OfferDto> CreateOfferAsync(CreateOfferDto createOfferDto,
        CancellationToken cancellationToken = default)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(createOfferDto.CategoryId, cancellationToken);
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {createOfferDto.CategoryId} not found");
        }

        var offerEntity = _mapper.Map<Offer>(createOfferDto);
        offerEntity.Status = OfferStatus.Active;
        offerEntity.EndTime = DateTime.Now.AddMinutes(createOfferDto.DurationInMinutes);

        await _unitOfWork.Offers.AddAsync(offerEntity, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return _mapper.Map<OfferDto>(offerEntity);
    }

    public async Task UpdateOfferAsync(Guid id, UpdateOfferDto updateOfferDto,
        CancellationToken cancellationToken = default)
    {
        var existingOffer = await _unitOfWork.Offers.GetByIdAsync(id, cancellationToken);
        if (existingOffer == null)
        {
            throw new KeyNotFoundException($"Offer with ID {id} not found");
        }

        if (existingOffer.Status == OfferStatus.Cancelled)
        {
            throw new InvalidOperationException("Cannot update a canceled offer");
        }

        _mapper.Map(updateOfferDto, existingOffer);

        _unitOfWork.Offers.Update(existingOffer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteOfferAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var offer = await _unitOfWork.Offers.GetByIdAsync(id, cancellationToken);
        if (offer == null)
        {
            throw new KeyNotFoundException($"Offer with ID {id} not found");
        }

        _unitOfWork.Offers.Delete(offer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task CancelOfferAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var offer = await _unitOfWork.Offers.GetByIdAsync(id, cancellationToken);
        if (offer == null)
        {
            throw new KeyNotFoundException($"Offer with ID {id} not found");
        }

        if (offer.Status == OfferStatus.Cancelled)
        {
            throw new InvalidOperationException("Offer is already canceled");
        }

        offer.Status = OfferStatus.Cancelled;

        _unitOfWork.Offers.Update(offer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}