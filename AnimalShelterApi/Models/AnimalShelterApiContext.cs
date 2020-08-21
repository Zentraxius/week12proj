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
        new Animal { AnimalId = 1, AdoptionFee = 0, AnimalName = "Toby", AnimalDescription = "Chonky Boi", AnimalHealth = "Healthy, all shots take care of, neutered!", SuggestedHome = "Toby is great with kids and an active environment, is also able to relax comfortably by himself or with cats, is afraid of other dogs." }
      );
    }
  }
}