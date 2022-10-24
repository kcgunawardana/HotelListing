﻿using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country 
                { 
                    Id=1,
                    Name="Jamaica",
                    ShortName="JM"
                    
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"

                },
                new Country
                {
                    Id = 3,
                    Name = "Caiman Island",
                    ShortName = "CI"

                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort Spa",
                    Address = "Negril",
                    CountryId = 1,  
                    Rating=4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Paldium",
                    Address = "George Town",
                    CountryId = 2,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Resort Spa",
                    Address = "Cayman",
                    CountryId = 3,
                    Rating = 4.5

                }
                );

        } 
        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }
    }
}
