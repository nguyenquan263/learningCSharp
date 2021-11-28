using System;
using System.Collections.Generic;
using LawyerCompanyProject.controllers;
using LawyerCompanyProject.models;
using LawyerCompanyProject.models.interfaces;
using LawyerCompanyProject.statics;

namespace LawyerCompanyProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEmployee emp = new Receptionist(1, "Quan", DateTime.Now, "Test", "qnguyen3", "123abc");

            Data.employees.Add(emp);

            Processor.logIn();

            
        }
    }
}
