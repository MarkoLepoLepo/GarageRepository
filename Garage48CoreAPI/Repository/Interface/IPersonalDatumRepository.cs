using System.Collections.Generic;
using System.Threading.Tasks;
using Garage48CoreAPI.Models;


namespace Garage48CoreAPI.Repository.Interface
{
    public interface IPersonalDatumRepository
    {
        IEnumerable<PersonalDatum> PersonalData { get; }
        Task<PersonalDatum> GetAsync(int id);
        void Update(PersonalDatum datum);
        void Delete(PersonalDatum datum);

        Task<bool> SaveChangesAsync();
    }
}