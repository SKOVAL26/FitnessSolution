using System;
using System.Threading;
/// <summary>
/// Gender
/// </summary>
namespace Fitness.BL.Model
{
  
    public class Gender
    {
        /// <summary>
        /// Gender Name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name">Gender name</param>>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender name can't be empty or Null", nameof(name)); 
            }
            Name = name;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
