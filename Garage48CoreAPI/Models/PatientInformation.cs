﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Garage48CoreAPI.Models
{
    public class PatientInformation
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Contacts { get; set; }
        public string Tag { get; set; }

        public int MedicalDataId { get; set; }
        public MedicalData MedicalHistory { get; set; }

        public virtual List<PatientDoctorMapping> Doctors { get; set; }

    }
}