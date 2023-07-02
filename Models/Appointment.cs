using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_doctorappointment.Models
{
    public class Appointment
    {

        public int Id { get; set; }
        public int SlotId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; } = "John Doe";
        public string ReservedAt { get; set; } = "30June";
    }
}