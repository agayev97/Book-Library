using AutoMapper;
using BookLibrary.Application.DTOs.Authors;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<List<AuthorDto>> GetAllAuthorsAsync()
        {
            var authors = await _authorRepository.GetAllAsync();
            return _mapper.Map<List<AuthorDto>>(authors);
        }

        public async Task<AuthorDto> GetByIdAsync(int id)
        {
            var author = await _authorRepository.GetByIdAsync(id);
            return _mapper.Map<AuthorDto>(author);
        }

        public async Task<AuthorDto> AddAuthorAsync(CreateAuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);

            await _authorRepository.AddAsync(author);
            await _authorRepository.SaveChangesAsync();

            return _mapper.Map<AuthorDto>(author);
        }

        public async Task  UpdateAuthorAsync(int id, UpdateAuthorDto authorDto)
        {
            var author = await _authorRepository.GetByIdAsync(authorDto.Id);
            if (author == null) throw new Exception("Author not found");

            _mapper.Map(authorDto, author);
            await _authorRepository.UpdateAsync(author);
            await _authorRepository.SaveChangesAsync();

        }

        public async Task DeleteAuthorAsync(int id)
        {
            var author = await _authorRepository.GetByIdAsync(id);
            if(author != null)
            {
                await _authorRepository.DeleteAsync(author);
            }

            await _authorRepository.SaveChangesAsync();
        }
    }
}
