using System.ComponentModel.DataAnnotations;

namespace API_PTTTHDT_.Data.Domain
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set;}
        public string StudentPhone { get; set;}
        public string Email { get; set;}
    }
}
