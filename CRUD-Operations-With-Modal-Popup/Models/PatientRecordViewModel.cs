namespace CRUD_Operations_With_Modal_Popup.Models
{
    public class PatientRecordViewModel
    {
        public int Id { get; set; }
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? DoctorName { get; set; }
        public int DoctorId { get; set; }
        public string? Type { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
