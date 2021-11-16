using System;
using System.Collections.Generic;
using System.Text;

namespace P2Les3.Classes
{
    /// <summary>
    /// Interface for persons with strengths
    /// </summary>
    public interface IHasStrengths
    {
        /// <summary>
        /// Add a strength to a Person
        /// </summary>
        /// <param name="strength"></param>
        void AddStrength(string strength);
        /// <summary>
        /// Get the strengths of a Person
        /// </summary>
        /// <returns></returns>
        List<string> GetStrength();
    }
}
