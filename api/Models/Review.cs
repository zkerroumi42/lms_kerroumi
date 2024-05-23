using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }=string.Empty;
        public DateTime Date_review { get; set; }
        public int? FormationId { get; set; }
        public Formation? Formation { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        
    }
}