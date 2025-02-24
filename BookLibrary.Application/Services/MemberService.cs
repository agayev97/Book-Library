using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class MemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILibrarianRepository _librarianRepository;

        public MemberService(IMemberRepository memberRepository, IUserRepository userRepository, ILibrarianRepository librarianRepository)
        {
            _memberRepository = memberRepository;
            _userRepository = userRepository;
            _librarianRepository = librarianRepository;
        }

        public async Task<List<Member>> GetAllMembersAsync()
        {
            return await _memberRepository.GetAllAsync();
        }

        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await _memberRepository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<Librarian>> GetAllLibrariansAsync()
        {
            return await _librarianRepository.GetAllAsync();
        }

        public async Task<Librarian> GetLibrarianBayIdAsync(int id)
        {
            return await _librarianRepository.GetByIdAsync(id);
        }

        public async Task AddMemberAsync(Member member)
        {
            if(member is User user)
            {
                await _userRepository.AddAsync(user);
            }
            else if(member is Librarian librarian)
            {
                await _librarianRepository.AddAsync(librarian);
            }
            else
            {
                await _memberRepository.AddAsync(member);
            }
        }

        public async Task UpdateMemberAsync(Member member)
        {
            if(member is User user)
            {
                await _userRepository.UpdateAsync(user);
            }
            else if(member is Librarian librarian)
            {
                await _librarianRepository.UpdateAsync(librarian);
            }
            else
            {
                await _memberRepository.UpdateAsync(member);
            }
        }

        public async Task DeleteMemberAsync(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if(member != null)
            {
                await _memberRepository.DeleteAsync(member);
            }
        }
    }
}
