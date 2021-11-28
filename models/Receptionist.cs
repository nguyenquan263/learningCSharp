using LawyerCompanyProject.models.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Receptionist : IEmployee
    {
        private int id;
        private string name;
        private DateTime joinedOn;
        private string otherExpertise;
        private string userName;
        private string password;

        public Receptionist(int id, string name, DateTime joinedOn, string otherExpertise, string userName, string password)
        {
            this.id = id;
            this.name = name;
            this.joinedOn = joinedOn;
            this.otherExpertise = otherExpertise;
            this.userName = userName;
            this.password = password;
        }

        public int getEmployeeId()
        {
            return this.id;
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
            return "Receptionist";
        }

        public string getUsername()
        {
            return this.userName;
        }

        public void setEmployeeId(int employeeId)
        {
            this.id = employeeId;
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

        public void setUsername(string userName)
        {
            this.userName = userName;
        }

        public override string ToString()
        {
            return "Employee Id: " + this.id + "\n"
                + "Name: " + this.name + "\n"
                + "Other expertise: " + this.otherExpertise + "\n"
                + "Joined on: " + this.joinedOn.ToShortDateString()
                + "Position: " + this.getPosition();
        }
    }
}
