using System.Collections.Generic;
using System.Threading.Tasks;
using Garage48CoreAPI.Models;
using Garage48CoreAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Garage48CoreAPI.Repository.Implementation
{
    public class PersonalDatumRepository : IPersonalDatumRepository
    {
        private readonly PatientContext _context;
        public PersonalDatumRepository(PatientContext context)
        {
            _context = context;
        }
        
        public IEnumerable<PersonalDatum> PersonalData { get; }
        
        public async Task<PersonalDatum> GetAsync(int id)
        {
            return await _context.PersonalData.FindAsync(id);
        }

        public void Update(PersonalDatum datum)
        {
            _context.PersonalData.Attach(datum);
            _context.Entry(datum).State = EntityState.Modified;
        }

        public void Delete(PersonalDatum datum)
        {
            _context.PersonalData.Remove(datum);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}