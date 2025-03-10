using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books {  get; set; }
        public DbSet<Author> Authors {  get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookRental> BookRentals {  get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });


            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);


            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);


            modelBuilder.Entity<BookRental>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BookRentals)
                .HasForeignKey(br => br.BookId);


            modelBuilder.Entity<BookRental>()
                .HasOne(br => br.Member)
                .WithMany(m => m.BookRentals)
                .HasForeignKey(br => br.MemberId);

            modelBuilder.Entity<BookRental>()
                .Property(br => br.Id)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Librarian>().ToTable("Librarians");

            modelBuilder.Entity<Member>()
                .HasIndex(m => m.Email)
                .IsUnique();

            modelBuilder.Entity<Book>()
                .Property(b => b.IsAvailable)
                .HasDefaultValue(true);
        }
    }
}
