using AutoMapper;
using BookLibrary.Application.DTOs.Auth;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Application.Exceptions;
using BookLibrary.Application.Helpers;
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
            var user = _userRepo.GetAll()
                .FirstOrDefault(u => u.UserName == requestDto.UserName && u.IsActive);

            if (user == null)
            {
                throw new UserNotFoundException();
            }

            var inputHashedPassword = PasswordHasher.HashPassword(requestDto.Password, user.PasswordSalt);

            if(user.PasswordHash != inputHashedPassword)
            {
                throw new InvalidCredentialsException();
            }


            var roleIds =  _userRoleRepo.GetAll()
                .Where(ur => ur.UserId == user.Id)
                .Select(ur => ur.RoleId)
                .ToList();

            var roleNames = _roleRepo.GetAll()
                .Where(r => roleIds.Contains(r.Id))
                .Select(r => r.Name)
                .ToList();


            var token = _jwtService.GenerateToken(user, roleNames);
            var userDto = _mapper.Map<UserDto>(user);

            return new LoginResponseDto
            {
                Token = token,
                User = userDto,
                Roles = roleNames
            };
        }

        public async Task RegisterAsync(RegisterRequestDto registerDto)
        {
            var usersExists = _userRepo.GetAll()
                .Any(u => u.UserName == registerDto.UserName || u.Email == registerDto.Email);
            {
                throw new Exception("Istifadeci adi ve ya email artiq movcuddur.");
            }

            var salt = PasswordHasher.GenerateSalt();
            var hashedPassword = PasswordHasher.HashPassword(registerDto.Password, salt);

            var newUser = _mapper.Map<User>(registerDto);

            newUser.FullName = registerDto.FullName;
            newUser.PasswordSalt = salt;
            newUser.PasswordHash = hashedPassword;
            newUser.IsActive = true;
            newUser.CreatedAt = DateTime.Now;

            await _userRepo.AddAsync(newUser);
            await _userRepo.SaveChangesAsync();

            var defaultRole = _roleRepo.GetAll()
                .FirstOrDefault(r => r.Name == "User");

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
            var users = _userRepo.GetAll().ToList();
            return _mapper.Map<List<UserDto>>(users);
        }

    }
}
