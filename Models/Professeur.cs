namespace PfaFinal.Models
{
    public partial class Professeur
    {
        public int Id { get; set; }
        public string? Specialite { get; set; }
        public string? Matiere { get; set; }
        public String UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
