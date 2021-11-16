using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les3.Classes
{
    public class Villain : Person, IHasStrengths
    {
        public List<Minion> Minions = new List<Minion>();
        public List<string> Strengths = new List<string>();

        /// <summary>
        /// Create a Villain with a name
        /// </summary>
        /// <param name="name"></param>
        public Villain(string name) : base(name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Create a Villain with a name and a minion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minion"></param>
        public Villain(string name, Minion minion) : base(name)
        {
            this.Name = name;
            this.Minions.Add(minion);
        }

        /// <summary>
        /// Add a minion to a Villain
        /// </summary>
        /// <param name="minion"></param>
        public void AddMinion(Minion minion)
        {
            Minions.Add(minion);
        }

        /// <summary>
        /// Add a strength to a Villain
        /// </summary>
        /// <param name="strength"></param>
        public void AddStrength(string strength)
        {
            Strengths.Add(strength);
        }

        /// <summary>
        /// Get the strengths of a Villain
        /// </summary>
        /// <returns></returns>
        public List<string> GetStrength()
        {
            return Strengths;
        }
    }
}
