using System.ComponentModel.DataAnnotations;

namespace GVP.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        [MaxLength(10)]
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
