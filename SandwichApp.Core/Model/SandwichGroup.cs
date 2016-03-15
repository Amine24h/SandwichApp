using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine24hSandwich.Core.Model
{
    class SandwichGroup
    {
        public int SandwichGroupId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<Sandwich> Sandwiches { get; set; }
    }
}
