using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Church.Models.Events
{
    public class EventLists : DbContext
    {

        public EventLists(DbContextOptions<EventLists> options)
         : base(options)
        { }
        public DbSet<Events> Events
        { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>().HasData(
                new Events
                {
                    Id = 1,
                    Title = "Upcoming Event 1",
                    Description = "This is the description for the first upcoming event.",
                    ImageUrl = "/images/event1.jpg",
                    StartTime = DateTime.Now.AddDays(10),
                    EndTime = DateTime.Now.AddDays(11),
                    EventHappened = false
                },
                new Events
                {
                    Id = 2,
                    Title = "Upcoming Event 2",
                    Description = "This is the description for the second upcoming event.",
                    ImageUrl = "/images/event2.jpg",
                    StartTime = DateTime.Now.AddDays(20),
                    EndTime = DateTime.Now.AddDays(21),
                    EventHappened = false
                },
                new Events
                {
                    Id = 3,
                    Title = "Upcoming Event 3",
                    Description = "This is the description for the third upcoming event.",
                    ImageUrl = "/images/event3.jpg",
                    StartTime = DateTime.Now.AddMonths(2),
                    EndTime = DateTime.Now.AddMonths(2).AddDays(1),
                    EventHappened = false
                },
                new Events
                {
                    Id = 4,
                    Title = "Past Event 1",
                    Description = "This is the description for the first past event.",
                    ImageUrl = "/images/event4.jpg",
                    StartTime = DateTime.Now.AddDays(-10),
                    EndTime = DateTime.Now.AddDays(-9),
                    EventHappened = true
                },
                new Events
                {
                    Id = 5,
                    Title = "Past Event 2",
                    Description = "This is the description for the second past event.",
                    ImageUrl = "/images/event5.jpg",
                    StartTime = DateTime.Now.AddDays(-20),
                    EndTime = DateTime.Now.AddDays(-19),
                    EventHappened = true
                }
            );
        

    }
    }
}
