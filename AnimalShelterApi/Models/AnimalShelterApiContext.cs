using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
    : base(options)
    {

    }
    public DbSet<Animal> Animals {get;set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>() 
      .HasData(
        new Animal { AnimalId = 1, AnimalName = "Portland National Animal Shelter", DogsCats = 14.5, DogsDescription = "We have 14 dogs currently awaiting a new home! Check out our website to see them or come on by!", CatsDescription = "We have 5 purrfect cats looking for a furever home, come adopt one today!" }
      );
    }
  }
}