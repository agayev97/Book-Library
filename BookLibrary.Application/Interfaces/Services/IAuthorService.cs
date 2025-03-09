using BookLibrary.Application.DTOs.Authors;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IAuthorService
    {
        Task<List<AuthorDto>> GetAllAuthorsAsync();
        Task<AuthorDto> GetByIdAsync(int id);
        Task AddAuthorAsync(AuthorDto authorDto);
        Task UpdateAuthorAsync(AuthorDto authorDto);
        Task DeleteAuthorAsync(int id);
    }
}
