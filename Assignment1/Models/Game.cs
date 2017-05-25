namespace Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        public string GameId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public bool IsMultiplayer { get; set; }

        [Required]
        [StringLength(128)]
        public string GenreId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
