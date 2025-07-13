using AutoMapper;
using BookLibrary.Application.DTOs.BookLocations;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Application.Services
{
    public class BookLocationService : IBookLocationService
    {
        private readonly IBookLocationRepository _repo;
        private readonly IMapper _mapper;

        public BookLocationService(IBookLocationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<BookLocationDto>> GetAllAsync() =>
            _mapper.Map<List<BookLocationDto>>(await _repo.GetAllAsync()); 

        public async Task<BookLocationDto?> GetByIdAsync(int id) =>
            _mapper.Map<BookLocationDto>(await _repo.GetByIdAsync(id));

        public async Task AddAsync(CreateBookLocationDto dto)
        {
            await _repo.AddAsync(_mapper.Map<BookLocation>(dto));
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(UpdateBookLocationDto dto)
        {
            var entity = await _repo.GetByIdAsync(dto.Id)
                ?? throw new Exception("BookLocation tapilmadi");
            _mapper.Map(dto, entity);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if(entity != null)
            {
                await _repo.DeleteAsync(entity);
                await _repo.SaveChangesAsync();
            }
        }
    }
}
