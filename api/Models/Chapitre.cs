using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Chapitre
    {
        public int? FormationId { get; set; }
        public Formation? Formation { get; set; }
        public int Id { get; set; }
        public List<Tutoriel> Tutoriels { get; set; } = new List<Tutoriel>(); 
    }
}