using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage48CoreAPI.Models
{
    public class MedicalData
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public PatientInformation Patient { get; set; }

        public virtual List<MedicalRecord> Records { get; set; }
    }
}
