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

      
        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto dto)
        {
            await _userService.AddUserAsync(dto);
            return Ok("User added successfully.");
        }

  
        [HttpPut("edit")]
        public async Task<IActionResult> EditUser([FromBody] UpdateUserDto dto)
        {
            await _userService.EditUserAsync(dto);
            return Ok("User updated successfully.");
        }

    
        [HttpDelete("soft-delete/{id}")]
        public async Task<IActionResult> SoftDeleteUser(int id)
        {
            await _userService.SoftDeleteUserAsync(id);
            return Ok("User deleted (soft) successfully.");
        }

      
        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers(int page = 1, int pageSize = 10)
        {
            var users = await _userService.GetAllUsersAsync(page, pageSize);
            return Ok("users");
        }

    
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
        
        [HttpPost("role/add")]
        public async Task<IActionResult> AddRole([FromBody] CreateRoleDto dto)
        {
            await _userService.AddRoleAsync(dto);
            return Ok("Role added successfully.");
        }

    
        [HttpPut("role/edit")]
        public async Task<IActionResult> EditRole([FromBody] UpdateRoleDto dto)
        {
            await _userService.EditRoleAsync(dto);
            return Ok("Role updated successfully.");
        }

     
        [HttpDelete("role/soft-delete/{id}")]
        public async Task<IActionResult> SoftDeleteRole(int id)
        {
            await _userService.SoftDeleteRoleAsync(id);
            return Ok("Role deleted (soft) successfully.");
        }

     
        [HttpPost("assign-roles")]
        public async Task<IActionResult> AssignRolesToUser(int userId, [FromBody] List<int> roleIds)
        {
            await _userService.AssignRolesToUserAsync(userId, roleIds);
            return Ok("Roles assigned to user successfully.");
        }

    }
}
