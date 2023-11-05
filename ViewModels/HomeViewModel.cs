using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Club> Clubs { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}