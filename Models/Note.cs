﻿namespace CarCareTracker.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string NoteText { get; set; }
    }
}