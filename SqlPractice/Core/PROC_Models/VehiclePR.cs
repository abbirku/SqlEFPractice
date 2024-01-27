namespace SqlPractice.Core.PROC_Models
{
    public class VehiclePR
    {
        public int Id { get; set; }
        public string RegistrationNo { get; set; }
        public string RegistrationDate { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string AllocatedEmployee { get; set; }
        public string AllocationDate { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
