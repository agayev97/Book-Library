using AutoMapper;
using BookLibrary.Application.DTOs.Auth;
using BookLibrary.Application.DTOs.Authors;
using BookLibrary.Application.DTOs.BookLocations;
using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.DTOs.Roles;
using BookLibrary.Application.DTOs.Users;
using BookLibrary.Domain.Entities;

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

            

            //User Mapping
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User,CreateUserDto >().ReverseMap();
            CreateMap<User, UpdateUserDto >().ReverseMap();


            //BookLocation
            CreateMap<BookLocation, BookLocationDto>().ReverseMap();
            CreateMap<BookLocation, CreateBookLocationDto>().ReverseMap();
            CreateMap<BookLocation, UpdateBookLocationDto>().ReverseMap();

            CreateMap<RegisterRequestDto, User>();

            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();


        }
    }
}
