using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
    : base(options)
    {

    }
    public DbSet<Shelter> Shelters {get;set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shelter>() 
      .HasData(
        new Shelter { ShelterId = 1, Description = "Portland National Shelter", Dogs = 14, Cats = 5, DogsDescription = "We have 14 dogs currently awaiting a new home! Check out our website to see them or come on by!", CatsDescription = "We have 5 purrfect cats looking for a furever home, come adopt one today!" }
      );
    }
  }
}