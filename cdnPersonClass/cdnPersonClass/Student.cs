using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cdnPersonClass
{
    public class Student : Person
    {
        private String major;        
        private Double gpa;               
        private List<String> classesPassed = new List<String>();

        public String Major
        {
            get { return major; }
            set { if (value.ToString().ToUpper() == "IT" || value.ToString().ToUpper() == "MOS" || value.ToString().ToUpper() == "HIT" || value.ToString().ToUpper() == "MA" || value.ToString().ToUpper() == "CJ" || value.ToString().ToUpper() == "BAMM" || value.ToString().ToUpper() == "BAA") major = value.ToUpper(); }
        }

        public Double GradePointAverage
        {
            get { return gpa; }
            set { if(value >= 0.0 && value <= 4.0) gpa = value; }
        }

        public List<String> ClassesPassed
        {
            get { return classesPassed; }
            set { classesPassed = value; }
        }
    }
}
