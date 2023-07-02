using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_doctorappointment.Services
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAllAppointments();
        Task<Appointment> PostAppointment(Appointment newAppointment);
    }
}