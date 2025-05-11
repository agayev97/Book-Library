using AutoMapper;
using BookLibrary.Application.DTOs.Auth;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IJwtService _jwtService;
        private readonly IGenericRepository<User> _userRepo;
        private readonly IGenericRepository<UserRole> _userRoleRepo;
        private readonly IGenericRepository<Role> _roleRepo;
        private readonly IMapper _mapper;

        public AuthService(
            IJwtService jwtService,
            IGenericRepository<User> userRepo,
            IGenericRepository<UserRole> userRoleRepo,
            IGenericRepository<Role> roleRepo,
             IMapper mapper)
        {
            _jwtService = jwtService;
            _userRepo = userRepo;
            _userRoleRepo = userRoleRepo;
            _roleRepo = roleRepo;
            _mapper = mapper;   
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto requestDto)
        {
            var users = await _userRepo.GetAllAsync();
            var user = users.FirstOrDefault(u => u.UserName == requestDto.UserName && u.Password == requestDto.Password && u.IsActive);

            if (user == null)
            {
                throw new Exception("Istifadeci adi ve ya sifre yanlisdir");
            }

            var userRoles = await _userRoleRepo.GetAllAsync();
            var roleIds = userRoles
                .Where(ur => ur.UserId == user.Id)
                .Select(ur => ur.RoleId)
                .ToList();

            var roles = await _roleRepo.GetAllAsync();
            var roleNames = roles
                .Where(r => roleIds.Contains(r.Id))
                .Select(r => r.Name)
                .ToList();


            var token = _jwtService.GenerateToken(user, roleNames);
            var userDto = _mapper.Map<UserDto>(user);

            return new LoginResponseDto
            {
                Token = token,
                User = userDto
            };
        }

        public async Task RegisterAsync(RegisterRequestDto registerDto)
        {
            var users = await _userRepo.GetAllAsync();
            if (users.Any(u => u.UserName == registerDto.UserName || u.Email == registerDto.Email))
            {
                throw new Exception("Istifadeci adi ve ya email artiq movcuddur.");
            }

            var newUser = _mapper.Map<User>(registerDto);
            newUser.IsActive = true;
            newUser.CreatedAt = DateTime.Now;

            await _userRepo.AddAsync(newUser);
            await _userRepo.SaveChangesAsync();

            var roles = await _roleRepo.GetAllAsync();
            var defaultRole = roles.FirstOrDefault(r => r.Name == "User");

            if (defaultRole != null)
            {
                var userRole = new UserRole
                {
                    UserId = newUser.Id,
                    RoleId = defaultRole.Id
                };

                await _userRoleRepo.AddAsync(userRole);
                await _userRoleRepo.SaveChangesAsync();
            }
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepo.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

    }
}
