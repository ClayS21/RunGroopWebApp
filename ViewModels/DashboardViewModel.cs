using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.ViewModels
{
    public class DashboardViewModel
    {
        public List<Race> Races { get; set; }
        public List<Club> Clubs { get; set; }
    }
}