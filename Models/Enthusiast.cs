using System.ComponentModel.DataAnnotations;
    using System;
    namespace HobbyHub.Models
    {
        public class Enthusiast
        {
            [Key] // <- this tells entity to assign a key id to this field below
            public int EnthusiastId { get; set; } 
            public int HobbyId { get; set; }
            public int UserId { get; set; }
            public Hobby Hobby{ get; set;}
            public User User { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }