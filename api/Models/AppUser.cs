using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class AppUser
    {
        public int Id_user { get; set; }
        public string Nom { get; set; }=string.Empty;
        public string Prenom { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty;
        public string Mot_de_pass { get; set; }=string.Empty;
        public string Role { get; set; }=string.Empty;
        public List<Abonnement> Abonnements { get; set; } = new List<Abonnement>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Inscreption> Inscreptions { get; set; } = new List<Inscreption>();
        
    }
}