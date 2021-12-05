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
    }
}
