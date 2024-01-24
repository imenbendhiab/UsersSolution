using System.ComponentModel.DataAnnotations;

namespace UsersAPI.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "role name is required !!!")]
        public string RoleName { get; set; } = null!;
        [Required(ErrorMessage = " description is required !!!")]
        public string Description { get; set; } = null!;
    }
}
