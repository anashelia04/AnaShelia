using Application.DTOs.Category;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync(CancellationToken cancellationToken = default)
    {
        var categories = await _unitOfWork.Categories.GetAllAsync(cancellationToken);
        return _mapper.Map<IEnumerable<CategoryDto>>(categories);
    }

    public async Task<CategoryDto?> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id, cancellationToken);
        return category != null ? _mapper.Map<CategoryDto>(category) : null;
    }

    public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto createCategoryDto,
        CancellationToken cancellationToken = default)
    {
        bool categoryExists =
            await _unitOfWork.Categories.CategoryExistsAsync(createCategoryDto.Name, cancellationToken);
        if (categoryExists)
        {
            throw new InvalidOperationException($"Category with name '{createCategoryDto.Name}' already exists");
        }

        var categoryEntity = _mapper.Map<Category>(createCategoryDto);
        await _unitOfWork.Categories.AddAsync(categoryEntity, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return _mapper.Map<CategoryDto>(categoryEntity);
    }

    public async Task UpdateCategoryAsync(Guid id, UpdateCategoryDto updateCategoryDto,
        CancellationToken cancellationToken = default)
    {
        var existingCategory = await _unitOfWork.Categories.GetByIdAsync(id, cancellationToken);
        if (existingCategory == null)
        {
            throw new KeyNotFoundException($"Category with ID {id} not found");
        }

        if (!string.Equals(existingCategory.Name, updateCategoryDto.Name, StringComparison.OrdinalIgnoreCase))
        {
            bool categoryExists =
                await _unitOfWork.Categories.CategoryExistsAsync(updateCategoryDto.Name, cancellationToken);
            if (categoryExists)
            {
                throw new InvalidOperationException($"Category with name '{updateCategoryDto.Name}' already exists");
            }
        }

        _mapper.Map(updateCategoryDto, existingCategory);
        _unitOfWork.Categories.Update(existingCategory);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteCategoryAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var category = await _unitOfWork.Categories.GetByIdAsync(id, cancellationToken);
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {id} not found");
        }

        _unitOfWork.Categories.Delete(category);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}