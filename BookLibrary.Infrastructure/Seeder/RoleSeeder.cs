using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Infrastructure.Seeder
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(IGenericRepository<Role> roleRepo)
        {
            var existingRoles =  roleRepo.GetAll().ToList();
            var roleNames = new[] { "Admin", "User", "Librarian" };

            foreach(var roleName in roleNames)
            {
                if(!existingRoles.Any(r => r.Name == roleName))
                {
                    await  roleRepo.AddAsync(new Role { Name = roleName });
                }
            }

            await roleRepo.SaveChangesAsync();
        }
    }
}
