using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace HobbyHub.Models
    {
        public class User
        {
            
            [Key]
            public int UserId { get; set; }

            [Required]
            [MinLength(2)]
            public string FirstName { get; set; }

            [Required]
            [MinLength(2)]
            public string LastName { get; set; }

            [Required]
            [MinLength (3)]
            [MaxLength (15)]
            public string UserName { get; set; }

            [Required]
            [MinLength(8)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [NotMapped] 
            [DataType(DataType.Password)]
            public string ConfPass { get; set; }

            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            public List<Hobby> UserHobby {get; set; } //Connects Users to hobby they created
            public List<Enthusiast> UserHobbyFans{ get; set; } //Connects Users to Enthusiast they created
            
        }

        public class Login
        {
            public string UserLogin { get; set; }

            [DataType(DataType.Password)]
            public string PasswordLogin { get; set; }

        }
    }