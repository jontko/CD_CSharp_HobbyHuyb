using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace HobbyHub.Models
    {
        public class Hobby
        {
            
            [Key]
            public int HobbyId { get; set; }
            
            [Required]
            public string Name { get; set; }
            
            public int UserId { get; set; }

            [Required]
            public string Description { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            public User HobbyOwner { get; set; }
            public List<Enthusiast> HobbyLiker { get; set; }
        }
    }