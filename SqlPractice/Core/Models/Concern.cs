namespace SqlPractice.Core.Models
{
    public class Concern : BaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string ShortCode { get; set; }
    }
}
