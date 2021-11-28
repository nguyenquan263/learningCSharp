using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models.interfaces
{
    interface ILawyer : IEmployee
    {
        public bool isSenior();
        public void setSenior(bool isSeniorPos);
        public void setDOB(DateTime dob);
        public DateTime getDOB();
        public void setYearOfExperience(int yearOfExperience);
        public int getYearOfExperience();
        public void setSpecialization(string specialization);
        public string getSpecialization();
    }
}
