using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Abonnement
    {
        public int Id { get; set; }
        public int Id_user { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public string Status { get; set; }=string.Empty;
        public int Prix { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}