using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreaterTournament.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public int Rating { get; set; }

        public string IPIN { get; set; }
    }
}
