using Day19_OneToMany.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day19_OneToMany.API
{
    public class CategoryController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        public IHttpActionResult Get()
        {
            return Ok(_db.Categories.ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var data = _db.Categories.Where(c => c.Id == id).Include(c => c.Movies).FirstOrDefault();

            //var data = _db.Movies.Where(m => m.Category.Name == "Action").ToList();

            return Ok(data);
        }
    }
}
