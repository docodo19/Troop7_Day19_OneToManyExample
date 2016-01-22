using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day19_OneToMany.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public ICollection<Actor> Actors { get; set; }
    }
}
