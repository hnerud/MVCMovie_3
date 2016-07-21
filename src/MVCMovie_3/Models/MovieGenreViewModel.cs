﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie_3.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies> movies;
        public SelectList genres;

        public string movieGenre { get; set; }

    }
}
