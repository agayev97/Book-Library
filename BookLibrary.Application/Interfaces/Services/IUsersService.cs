using BookLibrary.Application.DTOs.Roles;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IUsersService
    {
        Task AddUserAsync(CreateUserDto createDto);
        Task EditUserAsync(UpdateUserDto updateDto);
        Task SoftDeleteUserAsync(int id);
        Task<List<UserDto>> GetAllUsersAsync(int page, int pageSize);
        Task<UserDto> GetUserByIdAsync(int id);

        Task<List<Role>> GetAllRolesAsync();
        Task AddRoleAsync(CreateRoleDto createDto);
        Task EditRoleAsync(UpdateRoleDto updateDto);
        Task SoftDeleteRoleAsync(int roleId);


        Task AssignRolesToUserAsync(int userId, List<int> roleIds);
    }
}
