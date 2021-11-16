using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les3.Classes
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int evilnessIndicator { get; set; }

        /// <summary>
        /// Create a person with a name
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Create a person with a name and evilnessIndicator
        /// </summary>
        /// <param name="name"></param>
        /// <param name="evilnessindicator"></param>
        public Person(string name, int evilnessindicator)
        {
            this.Name = name;

            if (evilnessindicator >= 0 || evilnessindicator <= 100)
            {
                this.evilnessIndicator = evilnessindicator;
            }
            else
            {
                this.evilnessIndicator = 50;
            }
        }

        public string GetName() { return this.Name; }

        /// <summary>
        /// Get the evilness of a person
        /// </summary>
        /// <returns></returns>
        public int GetEvilness() { return evilnessIndicator; }
    }
}
