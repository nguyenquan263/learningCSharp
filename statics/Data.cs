using LawyerCompanyProject.models;
using LawyerCompanyProject.models.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.statics
{
    class Data
    {
        public static List<Appointment> appointments = new List<Appointment>();
        public static List<Case> cases = new List<Case>();
        public static List<Client> clients = new List<Client>();
        public static List<IEmployee> employees = new List<IEmployee>();
        public static IEmployee currentUser;


        //helpers
        public static bool checkLawyerId(int lawyerId) {
            for (int i = 0; i < employees.Count; i++) {
                IEmployee currentEmp = employees[i];

                if (currentEmp.getPosition() == "Lawyer") {
                    if (currentEmp.getEmployeeId() == lawyerId) {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool isValidPeriod(DateTime meetingTime, string meetingRoom) {

            if (appointments.Count == 0) return true;

            for (int i = 0; i < appointments.Count; i++) {
                DateTime existedMeetingTime = appointments[i].getDateTime();
                string existedMeetingRoom = appointments[i].getMeetingRoom();

                if (meetingRoom == existedMeetingRoom) {
                    if (existedMeetingTime.AddHours(1) <= meetingTime || existedMeetingTime > meetingTime) {
                        return true;
                    }
                }
            }
            Console.WriteLine("Time conflict! Try again!");
            return false;
        }
    }
}
