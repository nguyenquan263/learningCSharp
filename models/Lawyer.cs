using LawyerCompanyProject.models.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Lawyer : ILawyer
    {
        private DateTime dob;
        private int employeeId;
        private DateTime joinedDate;
        private string name;
        private string otherExpertise;
        private string specialization;
        private int yearOfExperience;
        private bool isSeniorPos;
        private string userName;
        private string password;

        public Lawyer(DateTime dob, int employeeId, DateTime joinedDate, string name, string otherExpertise, string specialization, int yearOfExperience, bool isSeniorPos, string userName, string password)
        {
            this.dob = dob;
            this.employeeId = employeeId;
            this.joinedDate = joinedDate;
            this.name = name;
            this.otherExpertise = otherExpertise;
            this.specialization = specialization;
            this.yearOfExperience = yearOfExperience;
            this.isSeniorPos = isSeniorPos;
            this.userName = userName;
            this.password = password;
        }

        public DateTime getDOB()
        {
            return this.dob;
        }

        public int getEmployeeId()
        {
            return this.employeeId;
        }

        public DateTime getJoinedDate()
        {
            return this.joinedDate;
        }

        public string getName()
        {
            return this.name;
        }

        public string getOtherExpertise()
        {
            return this.otherExpertise;
        }

        public string getPosition()
        {
            return "Lawyer";
        }

        public string getSpecialization()
        {
            return this.specialization;
        }

        public int getYearOfExperience()
        {
            return this.yearOfExperience;
        }

        public bool isSenior()
        {
            return this.isSeniorPos;
        }

        public void setSenior(bool isSeniorPos) {
            this.isSeniorPos = isSeniorPos;
        }

        public void setDOB(DateTime dob)
        {
            this.dob = dob;
        }

        public void setEmployeeId(int employeeId)
        {
            this.employeeId = employeeId;
        }

        public void setJoinedDate(DateTime joinedDate)
        {
            this.joinedDate = joinedDate;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setOtherExpertise(string otherExpertise)
        {
            this.otherExpertise = otherExpertise;
        }

        public void setSpecialization(string specialization)
        {
            this.specialization = specialization;
        }

        public void setYearOfExperience(int yearOfExperience)
        {
            this.yearOfExperience = yearOfExperience;
        }

        

        public string getUsername()
        {
            return this.userName;
        }

        public void setUsername(string userName)
        {
            this.userName = userName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public override string ToString()
        {
            return "Employee Id: " + this.employeeId + "\n"
                + "Name: " + this.name + "\n"
                + "Joined On: " + this.joinedDate.ToShortDateString() + "\n"
                + "Date of birth: " + this.dob + "\n"
                + "Year of experience: " + this.yearOfExperience + "\n"
                + "Specialization: " + this.specialization + "\n"
                + "Other expertise: " + this.otherExpertise + "\n"
                + "Position: " + this.getPosition();
         }


    }
}
