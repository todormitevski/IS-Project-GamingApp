using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.DomainEntities
{
    public class Developer : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public string Address { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
