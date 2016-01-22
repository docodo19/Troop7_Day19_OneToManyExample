﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day19_OneToMany.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}