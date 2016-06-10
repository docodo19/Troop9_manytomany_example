using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CoolCoffee.Models;

namespace CoolCoffee.Data
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider sp)
        {
            var db = sp.GetService<ApplicationDbContext>();

            #region seed Movie
            if (!db.Movies.Any())
            {
                var movies = new Movie[]
                {
                    new Movie {
                        Title = "Star Wars",
                        Director = "Lucas"
                    },
                    new Movie
                    {
                        Title = "Life at CoderCamps",
                        Director = "Jerry"
                    }
                };
                db.Movies.AddRange(movies);
                db.SaveChanges();
            }
            #endregion

            #region seed Actor
            if (!db.Actors.Any())
            {
                var actors = new Actor[] {
                    new Actor
                    {
                        FirstName = "Timmy",
                        LastName = "Smith"
                    },
                    new Actor
                    {
                        FirstName = "Eric",
                        LastName = "Cartman"
                    }
                };
                db.Actors.AddRange(actors);
                db.SaveChanges();
            }
            #endregion

            #region seed MovieActors
            if (!db.MovieActors.Any())
            {
                var moviesActors = new MovieActor[] {
                    new MovieActor
                    {
                        MovieId = db.Movies.FirstOrDefault(m => m.Title == "Star Wars").Id,
                        ActorId = db.Actors.FirstOrDefault(a => a.FirstName == "Timmy").Id
                    },
                    new MovieActor
                    {
                        MovieId = db.Movies.FirstOrDefault(m => m.Title == "Star Wars").Id,
                        ActorId = db.Actors.FirstOrDefault(a => a.FirstName == "Eric").Id
                    },
                    new MovieActor
                    {
                        MovieId = db.Movies.FirstOrDefault(m => m.Title == "Life at CoderCamps").Id,
                        ActorId = db.Actors.FirstOrDefault(a => a.FirstName == "Timmy").Id
                    }
                };
                db.MovieActors.AddRange(moviesActors);
                db.SaveChanges();
            }
            #endregion

        }

    }
}
