﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetVideoCore.Models
{
    public class VideoEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}