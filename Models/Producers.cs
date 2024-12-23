﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producers
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // relationships
        public List<Movie> Movies { get; set; }
    }
}
