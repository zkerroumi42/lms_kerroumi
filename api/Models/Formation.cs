using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Formation
    {
        public int Id { get; set; }
        public string Titre { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public bool Acces_abonnement { get; set; }
        public List<Chapitre> Chapitres { get; set; } = new List<Chapitre>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Inscreption> Inscreptions { get; set; } = new List<Inscreption>();   
    }
}