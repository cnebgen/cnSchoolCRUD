using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cdnPersonClass
{
    public class Teacher : Staff
    {
        private String department;        
        
        public String Department
        {
            get { return department; }
            set { if (value.ToString().ToUpper() == "IT" || value.ToString().ToUpper() == "MEDICAL" || value.ToString().ToUpper() == "CJ" || value.ToString().ToUpper() == "BUSINESS") department = value.ToUpper(); }
        }

    }
}
