using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models.interfaces
{
    interface IEmployee
    {
        public string getPosition();
        public void setEmployeeId(int employeeId);
        public int getEmployeeId();

        public void setName(string name);
        public string getName();

        public void setJoinedDate(DateTime joinedDate);
        public DateTime getJoinedDate();

        public void setOtherExpertise(string otherExpertise);
        public string getOtherExpertise();

        public string getUsername();
        public void setUsername(string userName);
        public string getPassword();
        public void setPassword(string password);



      
    }
}
