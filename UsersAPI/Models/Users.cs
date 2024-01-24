using System.ComponentModel.DataAnnotations;

namespace UsersAPI.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The organizer name is required !!!")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "The organizer name is required !!!")]
        public string LastName { get; set; } = null!;
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must set a valid email")]
        public string Email { get; set; } = null!;

        [RegularExpression(@"^[0-9\s\-\(\)]+$", ErrorMessage = "You must set a valid phone number")]

        public string Phone { get; set; } = null!;


        /*MotDePasse = MD5

        Date de création du compte
        Dernière date de connexion
        Statut du compte(actif, désactivé, etc.)*/
    }
}
