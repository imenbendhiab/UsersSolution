using System.ComponentModel.DataAnnotations;

namespace UsersAppClient.Models
{
    public class RolesClients
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "role name is required !!!")]
        public string RoleName { get; set; } = null!;
        [Required(ErrorMessage = " description is required !!!")]
        public string Description { get; set; } = null!;
    }
}
