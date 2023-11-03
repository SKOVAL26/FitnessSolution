using System;
using System.CodeDom;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        #region User propeties
        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// User Gender
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// User Birth Date
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// User Weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// User Height
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="name">User name.</param>
        /// <param name="gender">User gender.</param>
        /// <param name="birthDate">User bith date.</param>
        /// <param name="weight">User weight.</param>
        /// <param name="height">User height.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Checking User Parameters
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException("User name can't be empty or null.", nameof(name));  }
            
            if (gender == null){ 
                throw new ArgumentNullException("Gender can't be empty or null.", nameof(gender)); }
            
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate>=DateTime.Now){
                throw new ArgumentException("Wrong Birth Date", nameof(birthDate));
            }
            
            if (weight <= 0){
                throw new ArgumentException("Wrong weight. It can't be less or equals 0.", nameof(weight));
            }
            
            if (height <= 0){
                throw new ArgumentException("Wrong height. It can't be less or equals 0.", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
