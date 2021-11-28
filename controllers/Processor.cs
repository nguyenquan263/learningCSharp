using LawyerCompanyProject.models.interfaces;
using LawyerCompanyProject.statics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.controllers
{
    class Processor
    {
        public static bool logIn()
        {

            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            List<IEmployee> employeeList = Data.employees;
            int employeeListSize = employeeList.Count;

            for (int i = 0; i < employeeListSize; i++) {
                if (employeeList[i].getUsername().Equals(userName) && employeeList[i].getPassword().Equals(password)) {
                    Console.WriteLine("Login successfully!");
                    Data.currentUser = employeeList[i];
                    return true;
                }
            }
            Console.WriteLine("Wrong username or password!");
            return false;
        }


    }
}
