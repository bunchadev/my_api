using System.ComponentModel.DataAnnotations;

namespace API_PTTTHDT_.Model.Dto
{
    public class LoginDto
    {
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
