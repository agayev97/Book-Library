using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BookLibrary.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
<<<<<<< HEAD
        public DbSet<BookRental> BookRentals {  get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookLocation> BookLocations { get; set; }

=======
        public DbSet<BookRental> BookRentals { get; set; }
        public DbSet<User> Users { get; set; }
       
>>>>>>> 30a375c37371e3ee478ce5c054475b0d9c23f210

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
                .HasOne(br => br.User)
                .WithMany(u => u.BookRentals)
                .HasForeignKey(br => br.UserId);

            modelBuilder.Entity<Book>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Author>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<BookRental>()
                .Property(br => br.Id)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<Book>()
                .Property(b => b.IsAvailable)
                .HasDefaultValue(true);

<<<<<<< HEAD
            modelBuilder.Entity<Book>()
                .HasOne(b => b.BookLocation)
                .WithOne(bl => bl.Book)
                .HasForeignKey<BookLocation>(bl => bl.BookId);


=======
>>>>>>> 30a375c37371e3ee478ce5c054475b0d9c23f210
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });


            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);


            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }
    }
}