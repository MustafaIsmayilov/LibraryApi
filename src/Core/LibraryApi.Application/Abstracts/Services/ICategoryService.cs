using LibraryApi.Application.Dtos.CategoryDtos;
using LibraryApi.Application.Shared.Responses;

namespace LibraryApi.Application.Abstracts.Services;

public interface ICategoryService
{
    Task<BaseResponse<string>> AddAsync(CategoryCreateDto dto);
}
