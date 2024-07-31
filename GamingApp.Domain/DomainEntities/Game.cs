using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.DomainEntities
{
    public class Game : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Developer Developer { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Rating { get; set; }
    }
}
