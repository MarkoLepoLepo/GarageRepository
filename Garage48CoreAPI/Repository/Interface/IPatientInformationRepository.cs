using System.Collections.Generic;
using System.Threading.Tasks;
using Garage48CoreAPI.Repository.Implementation;
using Garage48CoreAPI.Models;

namespace Garage48CoreAPI.Repository.Interface
{
    public interface IPatientInformationRepository
    {
        IEnumerable<PatientInformation> PatientInformations { get; }
        Task<PatientInformation> GetAsync(int id);
        void Update(PatientInformation info);
        void Delete(PatientInformation info);

        Task<bool> SaveChangesAsync();
    }
}