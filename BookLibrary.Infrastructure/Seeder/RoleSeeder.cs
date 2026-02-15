using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Infrastructure.Seeder
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(IGenericRepository<Role> roleRepo)
        {
            var roleNames = new[] { "Admin", "User", "Librarian" };
            var existingRoles = roleRepo.GetAll().ToList();

            foreach (var roleName in roleNames)
            {
                var role = existingRoles
                    .FirstOrDefault(r => r.Name.ToLower() == roleName.ToLower());

                if(role == null)
                {
                    await roleRepo.AddAsync(new Role
                    {
                        Name = roleName,
                        IsActive = true
                    });
                }

                else if(!role.IsActive)
                {
                    role.IsActive = true;
                }
            }

            await roleRepo.SaveChangesAsync();
        }
    }
}
