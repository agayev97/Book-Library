using AutoMapper;
using BookLibrary.Application.DTOs.Authors;
using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.DTOs.Librarians;
using BookLibrary.Application.DTOs.Members;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Author Mapping
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            //Book Mapping
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();

            //BookRental Mapping
            CreateMap<BookRental, BookRentalDto>().ReverseMap();
            CreateMap<BookRental, CreateBookRentalDto>().ReverseMap();
            CreateMap<BookRental, UpdateBookRentalDto>().ReverseMap();

            //Member Mapping
            CreateMap<Member, MemberDto>().ReverseMap();
            CreateMap<Member, CreateMemberDto>().ReverseMap();
            CreateMap<Member, UpdateMemberDto>().ReverseMap();

            //User Mapping
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User,CreateUserDto >().ReverseMap();
            CreateMap<User, UpdateUserDto >().ReverseMap();

            //Librarian Mapping
            CreateMap<Librarian, LibrarianDto>().ReverseMap();
            CreateMap<Librarian, CreatedLibrarianDto>().ReverseMap();
            CreateMap<Librarian, UpdateLibrarianDto>().ReverseMap();
        }
    }
}
