using Microsoft.AspNetCore.Identity;

namespace PfaFinal.Models
{
    public class User : IdentityUser
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Adresse { get; set; }
        public int? Tel { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }

        // public virtual ICollection<Admin> Admins { get; set; }
        // public virtual ICollection<Professeur> Professeurs { get; set; }
    }
}
