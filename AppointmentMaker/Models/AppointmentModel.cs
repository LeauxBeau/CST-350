﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [DisplayName("Patient's Full Name")]
        [StringLength(20, MinimumLength = 4)]
        public string patientName {  get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName ("Appointment Request Date")]
        public DateTime dateTime { get; set; }

        [Required]
        [DisplayName("Patient's approximate net worth")]
        public decimal PatientNetWorth { get; set; }
        [DataType(DataType.Currency)
            ]
        [Required]
        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName {  get; set; }
        [Required]
        [Range(1, 10)]
        [DisplayName ("Patient's perceived level of pain (1 low to 10 high")]
        public int PainLevel {  get; set; }

        public AppointmentModel(string patientName, DateTime dateTime, decimal patientNetWorth, string doctorName, int painLevel)
        {
            this.patientName = patientName;
            this.dateTime = dateTime;
            PatientNetWorth = patientNetWorth;
            DoctorName = doctorName;
            PainLevel = painLevel;
        }

        public AppointmentModel()
        {

        }
    }
}
