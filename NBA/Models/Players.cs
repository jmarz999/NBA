using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBA.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Position { get; set; }
        public string Height_feet { get; set; }
        public string Height_inches { get; set; }
        public string Weight_pounds { get; set; }

        public Team Team { get; set; }
    }
}
