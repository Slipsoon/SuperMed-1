﻿using SuperMed.Models.Entities;
using System.Collections.Generic;

namespace SuperMed.Models.ViewModels
{
    public class DoctorAppointmentHistoryViewModel
    {
        public List<Appointment> RealizedAppointments { get; set; }
    }
}
