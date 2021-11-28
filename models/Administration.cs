using LawyerCompanyProject.models.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Administration : IAdministration
    {
        private int employeeId;
        private string name;
        private DateTime joinedOn;
        private string otherExpertise;
        private string role;
        private string userName;
        private string password;

        public Administration(int employeeId, string name, DateTime joinedOn, string otherExpertise, string role, string userName, string password)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.joinedOn = joinedOn;
            this.otherExpertise = otherExpertise;
            this.role = role;
            this.userName = userName;
            this.password = password;
        }

        public int getEmployeeId()
        {
            return this.employeeId;
        }

        public DateTime getJoinedDate()
        {
            return this.joinedOn;
        }

        public string getName()
        {
            return this.name;
        }

        public string getOtherExpertise()
        {
            return this.otherExpertise;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getPosition()
        {
            return "Administration";
        }

        public string getRole()
        {
            return this.role;
        }

        public string getUsername()
        {
            return this.userName;
        }

        public void setEmployeeId(int employeeId)
        {
            this.employeeId = employeeId;
        }

        public void setJoinedDate(DateTime joinedDate)
        {
            this.joinedOn = joinedDate;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setOtherExpertise(string otherExpertise)
        {
            this.otherExpertise = otherExpertise;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        public void setUsername(string userName)
        {
            this.userName = userName;
        }

        public override string ToString()
        {
            return "Employee Id: " + this.employeeId + "\n"
                + "Name: " + this.name + "\n"
                + "Joined on: " + this.joinedOn.ToShortDateString() + "\n"
                + "Role: " + this.role + "\n"
                + "Other expertise: " + this.otherExpertise
                + "Position: " + this.getPosition();
        }
    }
}
