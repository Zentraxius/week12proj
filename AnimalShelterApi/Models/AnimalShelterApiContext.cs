using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
    : base(options)
    {

    }
    public DbSet<Place> Places {get;set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>() 
      .HasData(
        new Place { PlaceId = 1, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 2, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 3, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" }
      );
    }
  }
}