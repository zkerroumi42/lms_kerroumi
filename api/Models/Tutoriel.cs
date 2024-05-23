using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Tutoriel
    {
        public int Id { get; set; }
        public string Titre { get; set; }=string.Empty;
        public string Url { get; set; }=string.Empty;
        public int Duree { get; set; }
        public DateTime Date_publication { get; set; }
        public int? ChapitreId { get; set; }
        public Chapitre? Chapitre { get; set; }
        
        
    }
}