using BookLibrary.Application.DTOs.Roles;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _userService;

        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

        // 1. Add User
        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto dto)
        {
            await _userService.AddUserAsync(dto);
            return Ok("User added successfully.");
        }

        // 2. Edit User
        [HttpPut("edit")]
        public async Task<IActionResult> EditUser([FromBody] UpdateUserDto dto)
        {
            await _userService.EditUserAsync(dto);
            return Ok("User updated successfully.");
        }

        // 3. Soft delete user
        [HttpDelete("soft-delete/{id}")]
        public async Task<IActionResult> SoftDeleteUser(int id)
        {
            await _userService.SoftDeleteUserAsync(id);
            return Ok("User deleted (soft) successfully.");
        }

        // 4. Get all users with pagination
        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers(int page = 1, int pageSize = 10)
        {
            var users = await _userService.GetAllUsersAsync(page, pageSize);
            return Ok("users");
        }

        // 5. Get user by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }

        [HttpGet("roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _userService.GetAllRolesAsync();
            return Ok(roles);
        }
        // 6. Add role
        [HttpPost("role/add")]
        public async Task<IActionResult> AddRole([FromBody] CreateRoleDto dto)
        {
            await _userService.AddRoleAsync(dto);
            return Ok("Role added successfully.");
        }

        // 7. Edit role
        [HttpPut("role/edit")]
        public async Task<IActionResult> EditRole([FromBody] UpdateRoleDto dto)
        {
            await _userService.EditRoleAsync(dto);
            return Ok("Role updated successfully.");
        }

        // 8. Soft delete role
        [HttpDelete("role/soft-delete/{id}")]
        public async Task<IActionResult> SoftDeleteRole(int id)
        {
            await _userService.SoftDeleteRoleAsync(id);
            return Ok("Role deleted (soft) successfully.");
        }

        // 9. Assign roles to user
        [HttpPost("assign-roles")]
        public async Task<IActionResult> AssignRolesToUser(int userId, [FromBody] List<int> roleIds)
        {
            await _userService.AssignRolesToUserAsync(userId, roleIds);
            return Ok("Roles assigned to user successfully.");
        }

    }
}
