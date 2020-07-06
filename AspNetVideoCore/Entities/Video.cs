using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Models;

namespace AspNetVideoCore.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required,MinLength(3),MaxLength(80)]
        public string Title { get; set; }
        [Display(Name ="Film Genre")]
        public int Genre { get; set; }
    }
}
