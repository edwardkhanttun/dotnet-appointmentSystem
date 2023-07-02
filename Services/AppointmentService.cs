using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_doctorappointment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly DataContext _context;

        public AppointmentService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Appointment>> GetAllAppointments()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> PostAppointment(Appointment newAppointment)
        {
            await _context.Appointments.AddAsync(newAppointment);
            await _context.SaveChangesAsync();
            return await _context.Appointments.FirstOrDefaultAsync(a => a.Id == newAppointment.Id);
        }
    }
}