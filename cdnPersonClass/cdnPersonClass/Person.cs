using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cdnPersonClass
{
    public abstract class Person
    {
        private String firstName = null;
        private String lastName = null;
        private Char gender;
        private DateTime birthdate = new DateTime();

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Count() <= 25)
                {
                    firstName = value;
                }
                else
                {
                    firstName = value.Remove(25);
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Count() <= 25)
                {
                    lastName = value;
                }
                else
                {
                    lastName = value.Remove(25);
                }
            }
        }

        /// <summary>
        /// This property allows  M or F for the gender. m or f are allowed, but will be saved as uppercase.
        /// </summary>
        public char Gender
        {
            get { return gender; }
            set { if (value.ToString().ToUpper() == "M" || value.ToString().ToUpper() == "F") gender = Convert.ToChar(value.ToString().ToUpper()); }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        /// <summary>
        /// Prints the first name.
        /// </summary>
        /// <param name="numTimes">Amount of times it prints first name.</param>
        /// <returns>A string of the first name.</returns>
        public string PrintSummary(int numTimes = 1)
        {
            for (int i = 1; i <= numTimes; i++)
            {
                Console.WriteLine(this.FirstName);
            }

            return this.FirstName;
        }

    }
}
