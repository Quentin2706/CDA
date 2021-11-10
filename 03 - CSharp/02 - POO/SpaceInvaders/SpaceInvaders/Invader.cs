using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Invader
    {
        public string Type { get; set; } = "#";

        public Invader(string type)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            return this.Type;
        }


    }
}
