using System.Collections.Generic;
using System.Threading.Tasks;
using Garage48CoreAPI.Models;
using Garage48CoreAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Garage48CoreAPI.Repository.Implementation
{
    public class PatientInformationRepository : IPatientInformationRepository
    {
        private readonly PatientContext _context;
        
        public PatientInformationRepository(PatientContext context)
        {
            _context = context;
        }
        public IEnumerable<PatientInformation> PatientInformations { get; }
        
        public async Task<PatientInformation> GetAsync(int id)
        {
            return await _context.PatientInformations.FindAsync(id);
        }

        public void Update(PatientInformation info)
        {
            _context.PatientInformations.Attach(info);
            _context.Entry(info).State = EntityState.Modified;
        }

        public void Delete(PatientInformation info)
        {
            _context.PatientInformations.Remove(info);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}