using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models.interfaces
{
    interface IEmployee
    {

        public abstract void setEmployeeId(int employeeId);
        public abstract int getEmployeeId();

        public abstract void setName(string name);
        public abstract string getName();

        public abstract void setDOB(DateTime dob);
        public abstract DateTime getDOB();

        public abstract void setYearOfExperience(DateTime dob);
        public abstract DateTime getYearOfExperience();

        public abstract void setSpecialization(string specialization);
        public abstract string getSpecialization();

        public abstract void setJoinedDate(DateTime joinedDate);
        public abstract DateTime getJoinedDate();

        public abstract void setOtherExpertise(string otherExpertise);
        public abstract string getOtherExpertise();

        public abstract override string ToString();
    }
}
