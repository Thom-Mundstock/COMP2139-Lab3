using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        DbSet<Contact> Contacts { get; set; }
        DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, 
                    Firstname = "Froddo", 
                    Lastname = "Begins", 
                    Phone = "416-123-4567", 
                    Email = "froddo@gmail.com", 
                    DateAdded = DateTime.Now, 
                    CategoryId = 1
                },
                new Contact
                {
                    ContactId = 2,
                    Firstname = "Samwise",
                    Lastname = "Gamgee",
                    Phone = "647-123-4567",
                    Email = "samwise@gmail.com",
                    DateAdded = DateTime.Now,
                    CategoryId = 2
                },
                new Contact
                {
                    ContactId = 3,
                    Firstname = "Pippen",
                    Lastname = "Took",
                    Phone = "905-123-4567",
                    Email = "pippen@gamil.com",
                    DateAdded = DateTime.Now,
                    CategoryId = 3
                }
                );
        }
    }
}
