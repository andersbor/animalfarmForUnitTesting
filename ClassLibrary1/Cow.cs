using System;

namespace ClassLibrary1
{
    /// <summary>
    /// Describes a cow 
    /// Invariant: weight >= 74
    /// </summary>
    public class Cow
    {
        private int _weight;

        // TODO Cow constructor with parameters
        // HACK something should be changed

        /// <summary>
        /// The weight of a cow
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value < 74)
                    throw new ArgumentOutOfRangeException("weight", value, "weight skal være min 74");
                _weight = value;
            }
        }
    }
}
