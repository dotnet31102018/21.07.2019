using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2107hw2
{
    public class Country
    {
        public string Capital { get; set; }
        public string Name { get; set; }
        public string ResourceFlagUrl { get; set; }

        public override string ToString()
        {
            return $"{Name} {Capital}";
        }
    }
}
