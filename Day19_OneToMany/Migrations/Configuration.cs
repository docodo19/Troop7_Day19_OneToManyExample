namespace Day19_OneToMany.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day19_OneToMany.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var actors = new Actor[]
            {
                new Actor { Name = "Arnold" },
                new Actor { Name = "Jim" },
                new Actor { Name = "Brad" },
                new Actor { Name = "Robert" }
            };
            context.Actors.AddOrUpdate(a => a.Name, actors);


            #region Seed Categories
            var categories = new Category[]
            {
                new Category {
                    Name = "Action",
                    Movies = new List<Movie>
                    {
                        new Movie { Title = "Die Hard", Director = "Bob",
                            Actors = new List<Actor> { actors[0], actors[1] }
                        },
                        new Movie { Title = "James Bond", Director = "Timmy",
                            Actors = new List<Actor> { actors[0], actors[1], actors[2] }
                        },
                        new Movie { Title = "Bourne Identity", Director = "Cartmen",
                            Actors = new List<Actor> { actors[1], actors[3] }
                        },
                        new Movie { Title = "Kill Bill", Director = "Courtney",
                            Actors = new List<Actor> { actors[0], actors[3] }
                        }
                    }
                },
                new Category
                {
                    Name = "SciFi",
                    Movies = new List<Movie>
                    {
                        new Movie { Title = "Star Wars 4", Director = "Lucas" },
                        new Movie { Title = "Star Wars 5", Director = "Lucas" },
                        new Movie { Title = "Star Wars 6", Director = "Lucas" }
                    }
                },
                new Category
                {
                    Name = "TV Show",
                    Movies = new List<Movie>
                    {
                        new Movie { Title = "Game of Thrones", Director = "Bob" },
                        new Movie { Title = "Walking Dead", Director = "Zombie" },
                        new Movie { Title = "24", Director = "Bauer" },
                        new Movie { Title = "House of Card", Director = "Kevin" }
                    }
                }
            };

            context.Categories.AddOrUpdate(c => c.Name, categories);
            #endregion
        }
    }
}
