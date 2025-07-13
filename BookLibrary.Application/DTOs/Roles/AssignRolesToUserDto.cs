

namespace BookLibrary.Application.DTOs.Roles
{
    public class AssignRolesToUserDto
    {
        public int UserId {  get; set; }
        public bool IsActive { get; set; }
        public List<int> RoleIds { get; set; } = new();
    }
}
