using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Dtos
{
    public class UserForDetailedDto
    {
      public int Id { get; set; } 
      public string Username { get; set; } 
      public string Sesso { get; set; }
      public int Age { get; set; }
      public string KnowAs { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime LastLogin { get; set; }
      public string LookingFor { get; set; }
      public string Introduction { get; set; }
      public string Interests { get; set; }
      public string City { get; set; }
      public string Country { get; set; }
      public string PhotoUrl { get; set; }
      public ICollection<PhotoForDetailedDto> Photos { get; set; }
    }
}