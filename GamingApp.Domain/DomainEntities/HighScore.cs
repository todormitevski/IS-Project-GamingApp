using GamingApp.Domain.DomainEntities;
using GamingApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.DomainEntities
{
    public class HighScore : BaseEntity
    {
        public Guid GameId { get; set; }
        public Game? Game { get; set; }
        [Required]
        public int Score { get; set; }

        public virtual GamingAppUser? User { get; set; }
    }
}