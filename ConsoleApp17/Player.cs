using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    abstract class Player
    {
        private string name;
        private Roshambo roshambo;
        public string Name { get => name; set => name = value; }
        internal Roshambo Roshambo { get => roshambo; set => roshambo = value; }

        public abstract Roshambo generateRoshambo();
    }
}
