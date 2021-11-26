using System;
using System.Collections.Generic;
using LawyerCompanyProject.models;
using LawyerCompanyProject.models.interfaces;
using LawyerCompanyProject.statics;

namespace LawyerCompanyProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(1, "Quan", "Ngoc Minh", "Nguyen", DateTime.Now, "Criminal", "Hermitage Dr", "219", "35630", "Florence");

            Console.WriteLine(client.ToString());

            client.setFirstName("Tram Anh");
            Console.WriteLine(client.ToString());

            Console.WriteLine(++currentAppointments.appointmentNumber);

          

            
        }
    }
}
