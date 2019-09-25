﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// https://asp.mvc-tutorial.com/getting-started/creating-a-model/

namespace HelloMVCWorld.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
