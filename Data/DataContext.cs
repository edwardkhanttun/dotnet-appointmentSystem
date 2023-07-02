using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet7_doctorappointment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Slot> Slots => Set<Slot>();  //use this to query and save DB character. Name has to same as name of corresponding database table, usually plural of entity.
        public DbSet<Appointment> Appointments => Set<Appointment>();
    }
}