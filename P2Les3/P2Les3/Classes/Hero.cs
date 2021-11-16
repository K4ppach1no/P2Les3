using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les3.Classes
{
    public class Hero : Person, IHasStrengths
    {
        public Villain Archnemesis { get; set; }
        public List<string> Strengths = new List<string>();
        public object Sidekick { get; set; }
        
        /// <summary>
        /// Create a Hero with a name and archnemesis
        /// </summary>
        /// <param name="name"></param>
        /// <param name="archnemesis"></param>
        public Hero(string name, Villain archnemesis) : base(name)
        {
            this.Name = name;
            this.Archnemesis = archnemesis;
        }

        /// <summary>
        /// Create a Hero with a name, archnemesis and sidekick
        /// </summary>
        /// <param name="name"></param>
        /// <param name="archnemesis"></param>
        /// <param name="sidekick"></param>
        public Hero(string name, Villain archnemesis, object sidekick) : base(name)
        {
            this.Name = name;
            this.Archnemesis = archnemesis;
            this.Sidekick = sidekick;
        }

        /// <summary>
        /// Get the archnemesis of a Hero
        /// </summary>
        /// <returns>Villain archnemesis</returns>
        public Villain GetArchnemesis() { return Archnemesis; }

        /// <summary>
        /// Update the sidekick of a Hero
        /// </summary>
        /// <param name="sidekick"></param>
        public void UpdateSidekick(object sidekick) { this.Sidekick = sidekick; }

        /// <summary>
        /// Get the sidekick of a hero
        /// </summary>
        /// <returns></returns>
        public object GetSidekick() { return this.Sidekick; }

        /// <summary>
        /// Add a strength to a Hero
        /// </summary>
        /// <param name="strength"></param>
        public void AddStrength(string strength)
        {
            Strengths.Add(strength);
        }

        /// <summary>
        /// Get the strength o
        /// </summary>
        /// <returns></returns>
        public List<string> GetStrength()
        {
            return Strengths;
        }
    }
}
