﻿using Microsoft.EntityFrameworkCore;
using TimeTrackerPMF.Domain;

namespace TimeTrackerPMF.Data
{
    public class TimeTrackerDbContext: DbContext
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}
