using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dotnet7_doctorappointment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet7_doctorappointment.Controllers
{
    [Route("doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Slot>>> Get()
        {
            return Ok(await _doctorService.GetAllSlots());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Slot>> GetDoctorAvailabilitiesById(int id)
        {
            return Ok(await _doctorService.GetSlotById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Slot>>> AddSlot(Slot newSlot)
        {
            await _doctorService.AddSlot(newSlot);
            return Ok("Appointment Created..");
        }
    }

}