using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRegistration.Models
{
    /// <summary>
    /// Represents an indiviual team object
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Name of the team (mascot)
        /// </summary>
        [Required]
        public string TeamName { get; set; }

        /// <summary>
        /// The designated captain/leader of the team
        /// </summary>
        [Required]
        public string TeamCaptain { get; set; }

        /// <summary>
        /// The head coach of the team
        /// </summary>
        [Required]
        public string CoachName { get; set; }

        /// <summary>
        /// The team's main style of play
        /// ex. Big, small, etc...
        /// </summary>
        [Required]
        public string Scheme { get; set; }

        /// <summary>
        /// The player position that the opposing team prepares for the most
        /// ex. PG, SG, SF, PF, C
        /// </summary>
        [Required]
        public string Playmaker { get; set; }


    }
}
