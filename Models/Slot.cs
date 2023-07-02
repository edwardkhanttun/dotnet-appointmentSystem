using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_doctorappointment.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public string Time { get; set; } = "30June";
        public int DoctorId { get; set; }
        public string DoctorName { get; set; } = "Unnammed Doctor";
        public bool IsReserved { get; set; }
        public double Cost { get; set; }
    }
}