using AutoMapper;
using BookLibrary.Application.DTOs.Roles;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Application.Exceptions;
using BookLibrary.Application.Helpers;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Application.Services
{
    public class UserService : IUsersService
    {
        private readonly IGenericRepository<User> _userRepo;
        private readonly IGenericRepository<Role> _roleRepo;
        private readonly IGenericRepository<UserRole> _userRoleRepo;
        private readonly IMapper _mapper;

        public UserService(
            IGenericRepository<User> userRepo,
            IGenericRepository<Role> roleRepo,
            IGenericRepository<UserRole> userRoleRepo,
            IMapper mapper)
        {
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _userRoleRepo = userRoleRepo;
            _mapper = mapper;
        }


        public async Task AddUserAsync(CreateUserDto dto)
        {
            var salt = PasswordHasher.GenerateSalt();
            var passwordHash = PasswordHasher.HashPassword(dto.Password, salt);


            var user = _mapper.Map<User>(dto);
            user.PasswordSalt = salt;
            user.PasswordHash = passwordHash;
            user.CreatedAt = DateTime.Now;
            user.IsActive = true;
            await _userRepo.AddAsync(user);
            await _userRepo.SaveChangesAsync();
        }

        public async Task EditUserAsync(UpdateUserDto dto)
        {
            var user = await _userRepo.GetByIdAsync(dto.Id);
            if (user == null || !user.IsActive) throw new UserNotFoundException();


            _mapper.Map(dto, user);
            user.UpdateAt = DateTime.Now;
            await _userRepo.SaveChangesAsync();
        }

        public async Task SoftDeleteUserAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if (user == null) throw new UserNotFoundException();

            user.IsActive = false;
            await _userRepo.SaveChangesAsync();
        }

        public async Task <List<UserDto>> GetAllUsersAsync(int page, int pageSize)
        {
            var users = _userRepo.GetAll()
                .Where(u => u.IsActive)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if (user == null || !user.IsActive) throw new UserNotFoundException();

            return _mapper.Map<UserDto>(user);
        }


        public async Task<List<Role>> GetAllRolesAsync()
        {
            var roles =  _roleRepo.GetAll().ToList();
            return roles;
        }

        public async Task AddRoleAsync(CreateRoleDto dto)
        {
            var role = _mapper.Map<Role>(dto);
            role.IsActive = true;

            await _roleRepo.AddAsync(role);
            await _roleRepo.SaveChangesAsync();
        }

        public async Task EditRoleAsync(UpdateRoleDto dto)
        {
            var role = await _roleRepo.GetByIdAsync(dto.Id);
            if (role == null || !role.IsActive)
                throw new RoleNotFoundException();

            _mapper.Map(dto, role);
            await _roleRepo.SaveChangesAsync();
        }

        public async Task SoftDeleteRoleAsync(int roleId)
        {
            var role = await _roleRepo.GetByIdAsync(roleId);
            if (role == null)
                throw new RoleNotFoundException();

            role.IsActive = false;
            await _roleRepo.SaveChangesAsync();
        }

        public async Task AssignRolesToUserAsync(int userId, List<int> roleIds)
        {
            var user = await _userRepo.GetByIdAsync(userId);
            if (user == null || !user.IsActive)
                throw new RoleNotFoundException();

            var userRoles = _userRoleRepo.GetAll()
                .Where(ur => ur.UserId == userId)
                .ToList();


            foreach (var roleId in roleIds)
            {
                if(!userRoles.Any(ur => ur.RoleId == roleId))
                {
                    var userRole = new UserRole
                    {
                        UserId = userId,
                        RoleId = roleId
                    };
                    await _userRoleRepo.AddAsync(userRole);
                }
            }
            await _userRoleRepo.SaveChangesAsync();
        }
    }
}
