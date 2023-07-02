using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet7_doctorappointment.Controllers
{
    [Route("appointment")]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Appointment>>> Get()
        {
            return Ok(await _appointmentService.GetAllAppointments());
        }

        [HttpPost]
        public async Task<ActionResult<List<Slot>>> AddAppointment(Appointment newAppointment)
        {
            await _appointmentService.PostAppointment(newAppointment);
            return Ok("Appointment Created..");
        }
    }
}