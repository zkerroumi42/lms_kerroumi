using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Formation
    {
        public int Id { get; set; }
        public List<Chapitre> Chapitres { get; set; } = new List<Chapitre>();  
    }
}