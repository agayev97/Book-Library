using BookLibrary.Application.DTOs.Librarians;
using BookLibrary.Application.DTOs.Members;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IMemberService
    {
        Task<List<MemberDto>> GetAllMembersAsync();
        Task<MemberDto> GetMemberByIdAsync(int id);

        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);

        Task<List<LibrarianDto>> GetAllLibrariansAsync();
        Task<LibrarianDto> GetLibrarianByIdAsync(int id);

        Task AddMemberAsync(MemberDto memberDto);
        Task UpdateMemberAsync(MemberDto memberDto);
        Task DeleteMemberAsync(int id);
    }
}
