using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
      public int Id { get; set; } 
      public string Username { get; set; } 
      public byte[] PasswordHash { get; set; }
      public byte[] PasswordSalt { get; set; }
      public string Sesso { get; set; }
      public DateTime DateOfBirth { get; set; }
      public string KnowAs { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime LastLogin { get; set; }
      public string LookingFor { get; set; }
      public string Introduction { get; set; }
      public string Interests { get; set; }
      public string City { get; set; }
      public string Country { get; set; }
      public ICollection<Photo> Photos { get; set; }
    }
}