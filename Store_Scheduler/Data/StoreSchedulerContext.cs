using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store_Scheduler.Models;

namespace Store_Scheduler.Data
{
    public class StoreSchedulerContext : DbContext
    {
        public StoreSchedulerContext(DbContextOptions<StoreSchedulerContext> options) :
            base(options)
        { }

        //Add a DbSet for each entity set
        public DbSet<department_positions> department_positions { get; set; }
        public DbSet<departments> departments { get; set; }
        public DbSet<employee_skills> employee_skills { get; set; }
        public DbSet<employee_stores> employee_stores { get; set; }
        public DbSet<employees> employees { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<shifts> shifts { get; set; }
        public DbSet<skills> skills { get; set; }
        public DbSet<stores> stores { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<weeklySchedule> weeklySchedule { get; set; }
    }
}
