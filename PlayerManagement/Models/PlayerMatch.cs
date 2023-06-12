﻿using System.ComponentModel.DataAnnotations;

namespace PlayerManagement.Models
{
    public class PlayerMatch
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the number of goals scored.")]
        [Range(0, int.MaxValue, ErrorMessage = "Goals must be a positive number.")]
        public int? Goals { get; set; }

        [Required(ErrorMessage = "You must enter the number of red cards received.")]
        [Range(0, int.MaxValue, ErrorMessage = "Red cards must be a positive number.")]
        public int? RedCards { get; set; }

        [Required(ErrorMessage = "You must enter the number of yellow cards received.")]
        [Range(0, int.MaxValue, ErrorMessage = "Yellow cards must be a positive number.")]
        public int? YellowCards { get; set; }

        [Required(ErrorMessage = "You must select a match.")]
        public int? MatchId { get; set; }
        public MatchSchedule Match { get; set; }

        [Required(ErrorMessage = "You must select a player.")]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
    }
}
