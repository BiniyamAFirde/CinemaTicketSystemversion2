using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaTicketSystem.Models
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }

        [Required]
        public DateTime ScreeningDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Theater { get; set; } = string.Empty;

        [Required]
        [Range(1, 500)]
        public int TotalSeats { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TicketPrice { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
}