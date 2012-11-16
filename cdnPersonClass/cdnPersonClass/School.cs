using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cdnPersonClass
{
    [Serializable()]
    public class School
    {
        private string name;        
        private string address1;
        private string address2;
        private string city;        
        private string state;        
        private string zipCode;        
        private string phoneNum;        
        private string faxNum;
    
        public List<Staff> StaffIs = new List<Staff>();        
        public List<Teacher> Teachers = new List<Teacher>();                
        public List<Student> Students = new List<Student>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public string FaxNum
        {
            get { return faxNum; }
            set { faxNum = value; }
        }

    }
}
