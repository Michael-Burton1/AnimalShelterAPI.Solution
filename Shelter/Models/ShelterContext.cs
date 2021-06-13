using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "John", Age = 15, Type="cat", Sex = "Male", Availible= true},
              new Animal { AnimalId = 2, Name = "Robb", Age = 15, Type="cat", Sex = "Male", Availible= false},
              new Animal { AnimalId = 3, Name = "Sansa", Age = 11, Type="cat", Sex = "Female", Availible= true},
              new Animal { AnimalId = 4, Name = "Bran", Age = 7, Type="cat", Sex = "Male", Availible= true},
              new Animal { AnimalId = 5, Name = "Arya", Age = 9, Type="cat", Sex = "Female", Availible= true},
              new Animal { AnimalId = 6, Name = "Rickon", Age = 3, Type="cat", Sex = "Male", Availible= false},
              new Animal { AnimalId = 7, Name = "Ghost", Age = 1, Type="dog", Sex = "Male", Availible= true},
              new Animal { AnimalId = 8, Name = "Grey Wind", Age = 1, Type="dog", Sex = "Male", Availible= false},
              new Animal { AnimalId = 9, Name = "Lady", Age = 1, Type="dog", Sex = "Female", Availible= false},
              new Animal { AnimalId = 10, Name = "Nymeria", Age = 1, Type="dog", Sex = "Female", Availible= true},
              new Animal { AnimalId = 11, Name = "Summer", Age = 1, Type="dog", Sex = "Male", Availible= false},
              new Animal { AnimalId = 12, Name = "Shaggy Dog", Age = 1, Type="dog", Sex = "Male", Availible= false}
              
          );
    }
    public ShelterContext(DbContextOptions<ShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  }
}