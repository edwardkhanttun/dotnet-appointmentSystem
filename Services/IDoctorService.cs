using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet7_doctorappointment.Services
{
    public interface IDoctorService
    {
        Task<List<Slot>> GetAllSlots();
        Task<Slot> GetSlotById(int id);
        Task<List<Slot>> AddSlot(Slot newSlot);
    }
}