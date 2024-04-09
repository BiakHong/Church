using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Church.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ExperienceTexts { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

      


    }
}