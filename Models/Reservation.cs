namespace PfaFinal.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public string? DateRes { get; set; }
        public string? HeureDebut { get; set; }
        public string? HeureFin { get; set; }
        public string? Status { get; set; }
        public int Id_Prof { get; set; }
        public int Id_Salle { get; set; }


    }
}