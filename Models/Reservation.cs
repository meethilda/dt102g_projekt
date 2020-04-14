using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dt102g_projekt.Models
{
    public class Reservation
    {
        // Properties
        public int reservationId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Datum")]
        public DateTime Date { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [DisplayName("Tid")]
        public DateTime Time { get; set; }
        [DisplayName("Skapad")]
        public DateTime Created { get; set; }
        public string userId { get; set; }
    }
}
