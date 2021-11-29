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
    }
}
