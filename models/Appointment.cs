using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Appointment
    {
        private int id;
        private int clientId;
        private int lawyerId;
        private DateTime dateTime;
        private string meetingRoom;
        private string shortDescription;

        public Appointment(int id, int clientId, int lawyerId, DateTime dateTime, string meetingRoom, string shortDescription)
        {
            this.id = id;
            this.clientId = clientId;
            this.lawyerId = lawyerId;
            this.dateTime = dateTime;
            this.meetingRoom = meetingRoom;
            this.shortDescription = shortDescription;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setClientId(int clientId)
        {
            this.clientId = clientId;
        }

        public int getClientId()
        {
            return this.clientId;
        }

        public void setLawyerId(int lawyerId)
        {
            this.lawyerId = lawyerId;
        }

        public int getLawyerId()
        {
            return this.lawyerId;
        }

        public void setDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTime getDateTime()
        {
            return this.dateTime;
        }

        public void setMeetingRoom(string meetingRoom)
        {
            this.meetingRoom = meetingRoom;
        }

        public string getMeetingRoom()
        {
            return this.meetingRoom;
        }

        public void setShortDescription(string shortDescription)
        {
            this.shortDescription = shortDescription;
        }

        public string getShortDescription()
        {
            return this.shortDescription;
        }

        public override string ToString()
        {
            return "Id: " + this.id + "\n"
                + "Client Id: " + this.clientId + "\n"
                + "Lawyer Id: " + this.lawyerId + "\n"
                + "Date Time: " + this.dateTime + "\n"
                + "Meeting Room: " + this.meetingRoom + "\n"
                + "Short Description: " + this.shortDescription;
        }


    }
}
