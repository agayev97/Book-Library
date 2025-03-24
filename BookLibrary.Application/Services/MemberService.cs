using AutoMapper;
using BookLibrary.Application.DTOs.Librarians;
using BookLibrary.Application.DTOs.Members;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILibrarianRepository _librarianRepository;
        private readonly IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IUserRepository userRepository, ILibrarianRepository librarianRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _userRepository = userRepository;
            _librarianRepository = librarianRepository;
            _mapper = mapper;
        }

        public async Task<List<MemberDto>> GetAllMembersAsync()
        {
            var members = await _memberRepository.GetAllAsync();
            return _mapper.Map<List<MemberDto>>(members);
        }

        public async Task<MemberDto> GetMemberByIdAsync(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            return _mapper.Map<MemberDto>(member);
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<List<LibrarianDto>> GetAllLibrariansAsync()
        {
            var librarians = await _librarianRepository.GetAllAsync();
            return _mapper.Map<List<LibrarianDto>>(librarians);
        }

        public async Task<LibrarianDto> GetLibrarianByIdAsync(int id)
        {
            var librarian = await _librarianRepository.GetByIdAsync(id);
            return _mapper.Map<LibrarianDto>(librarian);
        }

        public async Task <MemberDto>AddMemberAsync(CreateMemberDto memberDto)
        {
            var member = _mapper.Map<Member>(memberDto);
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
            await _memberRepository.SaveChangesAsync();

            return _mapper.Map<MemberDto>(member);
        }

        public async Task UpdateMemberAsync(int id, UpdateMemberDto memberDto)
        {
            var member = _mapper.Map<Member>(memberDto);
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
            await _memberRepository.SaveChangesAsync();
        }

        public async Task DeleteMemberAsync(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if(member != null)
            {
                await _memberRepository.DeleteAsync(member);
            }
            await _memberRepository.SaveChangesAsync();
        }
    }
}
