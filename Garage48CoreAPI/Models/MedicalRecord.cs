using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage48CoreAPI.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int MediacalDataId { get; set; }
        public MedicalData MedicalData { get; set; }


        public string Period { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public string Symptoms { get; set; }
        public string Analysis { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

        public string Tag { get; set; }

    }
}
