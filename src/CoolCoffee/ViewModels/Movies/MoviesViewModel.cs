using CoolCoffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolCoffee.ViewModels.Movies
{
    public class MoviesViewModel
    {
        public string Title { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
