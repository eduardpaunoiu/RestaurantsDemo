using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsDemo.Models
{
    public class Relation
    {
        public int Id { get; set; }

        public int IdRest { get; set; }

        public int IdFood { get; set; }
    }
}
