using System;
using Microsoft.EntityFrameworkCore;

namespace LaytonTempleTours.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext() { }

        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                    // MONDAY 
                    new Time { TimeId = 1, DateTime = new DateTime(2022, 03, 28, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 2, DateTime = new DateTime(2022, 03, 28, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 3, DateTime = new DateTime(2022, 03, 28, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 4, DateTime = new DateTime(2022, 03, 28, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 5, DateTime = new DateTime(2022, 03, 28, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 6, DateTime = new DateTime(2022, 03, 28, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 7, DateTime = new DateTime(2022, 03, 28, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 8, DateTime = new DateTime(2022, 03, 28, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 9, DateTime = new DateTime(2022, 03, 28, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 10, DateTime = new DateTime(2022, 03, 28, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 11, DateTime = new DateTime(2022, 03, 28, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 12, DateTime = new DateTime(2022, 03, 28, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 13, DateTime = new DateTime(2022, 03, 28, 20, 00, 0), SlotAvailable = true },

                    // TUESDAY 
                    new Time { TimeId = 14, DateTime = new DateTime(2022, 03, 29, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 15, DateTime = new DateTime(2022, 03, 29, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 16, DateTime = new DateTime(2022, 03, 29, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 17, DateTime = new DateTime(2022, 03, 29, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 18, DateTime = new DateTime(2022, 03, 29, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 19, DateTime = new DateTime(2022, 03, 29, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 20, DateTime = new DateTime(2022, 03, 29, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 21, DateTime = new DateTime(2022, 03, 29, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 22, DateTime = new DateTime(2022, 03, 29, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 23, DateTime = new DateTime(2022, 03, 29, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 24, DateTime = new DateTime(2022, 03, 29, 18, 00, 0), SlotAvailable = false },
                    new Time { TimeId = 25, DateTime = new DateTime(2022, 03, 29, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 26, DateTime = new DateTime(2022, 03, 29, 20, 00, 0), SlotAvailable = true },

                    // WEDNESDAY
                    new Time { TimeId = 27, DateTime = new DateTime(2022, 03, 30, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 28, DateTime = new DateTime(2022, 03, 30, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 29, DateTime = new DateTime(2022, 03, 30, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 30, DateTime = new DateTime(2022, 03, 30, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 31, DateTime = new DateTime(2022, 03, 30, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 32, DateTime = new DateTime(2022, 03, 30, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 33, DateTime = new DateTime(2022, 03, 30, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 34, DateTime = new DateTime(2022, 03, 30, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 35, DateTime = new DateTime(2022, 03, 30, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 36, DateTime = new DateTime(2022, 03, 30, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 37, DateTime = new DateTime(2022, 03, 30, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 38, DateTime = new DateTime(2022, 03, 30, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 39, DateTime = new DateTime(2022, 03, 30, 20, 00, 0), SlotAvailable = true },

                    // THURSDAY
                    new Time { TimeId = 40, DateTime = new DateTime(2022, 03, 31, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 41, DateTime = new DateTime(2022, 03, 31, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 42, DateTime = new DateTime(2022, 03, 31, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 43, DateTime = new DateTime(2022, 03, 31, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 44, DateTime = new DateTime(2022, 03, 31, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 45, DateTime = new DateTime(2022, 03, 31, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 46, DateTime = new DateTime(2022, 03, 31, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 47, DateTime = new DateTime(2022, 03, 31, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 48, DateTime = new DateTime(2022, 03, 31, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 49, DateTime = new DateTime(2022, 03, 31, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 50, DateTime = new DateTime(2022, 03, 31, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 51, DateTime = new DateTime(2022, 03, 31, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 52, DateTime = new DateTime(2022, 03, 31, 20, 00, 0), SlotAvailable = true },

                    // FRIDAY
                    new Time { TimeId = 53, DateTime = new DateTime(2022, 04, 01, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 54, DateTime = new DateTime(2022, 04, 01, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 55, DateTime = new DateTime(2022, 04, 01, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 56, DateTime = new DateTime(2022, 04, 01, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 57, DateTime = new DateTime(2022, 04, 01, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 58, DateTime = new DateTime(2022, 04, 01, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 59, DateTime = new DateTime(2022, 04, 01, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 60, DateTime = new DateTime(2022, 04, 01, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 61, DateTime = new DateTime(2022, 04, 01, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 62, DateTime = new DateTime(2022, 04, 01, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 63, DateTime = new DateTime(2022, 04, 01, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 64, DateTime = new DateTime(2022, 04, 01, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 65, DateTime = new DateTime(2022, 04, 01, 20, 00, 0), SlotAvailable = true },

                    // SATURDAY
                    new Time { TimeId = 66, DateTime = new DateTime(2022, 04, 02, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 67, DateTime = new DateTime(2022, 04, 02, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 68, DateTime = new DateTime(2022, 04, 02, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 69, DateTime = new DateTime(2022, 04, 02, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 70, DateTime = new DateTime(2022, 04, 02, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 71, DateTime = new DateTime(2022, 04, 02, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 72, DateTime = new DateTime(2022, 04, 02, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 73, DateTime = new DateTime(2022, 04, 02, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 74, DateTime = new DateTime(2022, 04, 02, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 75, DateTime = new DateTime(2022, 04, 02, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 76, DateTime = new DateTime(2022, 04, 02, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 77, DateTime = new DateTime(2022, 04, 02, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 78, DateTime = new DateTime(2022, 04, 02, 20, 00, 0), SlotAvailable = true },

                    // SUNDAY
                    new Time { TimeId = 79, DateTime = new DateTime(2022, 04, 03, 8, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 80, DateTime = new DateTime(2022, 04, 03, 9, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 81, DateTime = new DateTime(2022, 04, 03, 10, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 82, DateTime = new DateTime(2022, 04, 03, 11, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 83, DateTime = new DateTime(2022, 04, 03, 12, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 84, DateTime = new DateTime(2022, 04, 03, 13, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 85, DateTime = new DateTime(2022, 04, 03, 14, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 86, DateTime = new DateTime(2022, 04, 03, 15, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 87, DateTime = new DateTime(2022, 04, 03, 16, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 88, DateTime = new DateTime(2022, 04, 03, 17, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 89, DateTime = new DateTime(2022, 04, 03, 18, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 90, DateTime = new DateTime(2022, 04, 03, 19, 00, 0), SlotAvailable = true },
                    new Time { TimeId = 91, DateTime = new DateTime(2022, 04, 03, 20, 00, 0), SlotAvailable = true }

                );

        }
    }
}






