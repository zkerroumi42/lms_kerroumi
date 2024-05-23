using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Inscreption
    {
        public int Id { get; set; }
        public DateTime Date_inscription { get; set; }
        public string Type_inscription { get; set; }=string.Empty;
        public int? FormationId { get; set; }
        public Formation? Formation { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        
    }
}