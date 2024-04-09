using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Church.Models
{
    public class ExperienceLists : DbContext
    {

        public ExperienceLists(DbContextOptions<ExperienceLists> options)
         : base(options)
        { }
        public DbSet<Experience> Experiences
            { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    Name = "Tedd",
                    ExperienceTexts = "The people are very welcoming and nice.",
                    CreatedAt = DateTime.Now
                },
            new Experience
            {
                Id = 2,
                Name = "Mike",
                ExperienceTexts = "I feel the present of God in this church.",
                CreatedAt = DateTime.Now
            },
            new Experience
            {
                Id = 3,
                Name = "John",
                ExperienceTexts = "Worship team are so so good.",
                CreatedAt = DateTime.Now
            });
        }
    }
}
