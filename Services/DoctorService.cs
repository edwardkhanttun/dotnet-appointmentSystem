using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet7_doctorappointment.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly DataContext _context;

        public DoctorService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Slot>> GetAllSlots()
        {
            return await _context.Slots.ToListAsync();

        }
        public async Task<Slot> GetSlotById(int id)
        {
            var slotByID = await _context.Slots.FirstOrDefaultAsync(d => d.Id == id);
            return slotByID;
        }

        public async Task<List<Slot>> AddSlot(Slot newSlot)
        {
            await _context.Slots.AddAsync(newSlot);
            await _context.SaveChangesAsync();
            return await _context.Slots.ToListAsync();
        }
    }
}