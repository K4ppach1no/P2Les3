using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les3.Classes
{
    public class Minion : Person
    {
        /// <summary>
        /// Create a Minion with a name
        /// </summary>
        /// <param name="name"></param>
        public Minion(string name) : base(name)
        {
            this.Name = name;
        }

        public string Weakness { get; set; }
    }
}
