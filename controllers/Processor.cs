using LawyerCompanyProject.models;
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
            int trialTime = 3;

            while (trialTime > 0) {
                Console.Write("Enter your username: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                List<IEmployee> employeeList = Data.employees;
                int employeeListSize = employeeList.Count;

                for (int i = 0; i < employeeListSize; i++)
                {
                    if (employeeList[i].getUsername().Equals(userName) && employeeList[i].getPassword().Equals(password))
                    {
                        Console.WriteLine("Login successfully!");
                        Data.currentUser = employeeList[i];
                        return true;
                    }
                }

                Console.WriteLine("Wrong username or password! Try again.");
                trialTime--;
            }

            Console.WriteLine("You input incorrect so many time! We need to stop the application!");
            return false;
        }

        public static void setUpEmployees()
        {
            Lawyer sl1 = new Lawyer(new DateTime(1996, 3, 26), 1, new DateTime(2015, 12, 12), "Bruce Wayne", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, true, "bwayne", "123abc");
            Lawyer sl2 = new Lawyer(new DateTime(1996, 3, 26), 2, new DateTime(2015, 12, 12), "Dick Grayson", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, true, "dgrayson", "123abc");
            Lawyer sl3 = new Lawyer(new DateTime(1996, 3, 26), 3, new DateTime(2015, 12, 12), "Harvey Dent", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, true, "hdent", "123abc");
            Lawyer sl4 = new Lawyer(new DateTime(1996, 3, 26), 4, new DateTime(2015, 12, 12), "Rachel Dawn", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, true, "rdawn", "123abc");
            Lawyer sl5 = new Lawyer(new DateTime(1996, 3, 26), 5, new DateTime(2015, 12, 12), "Harvey Bullock", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, true, "hbullock", "123abc");

            Data.employees.Add(sl1);
            Data.employees.Add(sl2);
            Data.employees.Add(sl3);
            Data.employees.Add(sl4);
            Data.employees.Add(sl5);

            Lawyer jl1 = new Lawyer(new DateTime(1996, 3, 26), 6, new DateTime(2015, 12, 12), "Tim Drake", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "tdrake", "123abc");
            Lawyer jl2 = new Lawyer(new DateTime(1996, 3, 26), 7, new DateTime(2015, 12, 12), "Jason Todd", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "jtodd", "123abc");
            Lawyer jl3 = new Lawyer(new DateTime(1996, 3, 26), 8, new DateTime(2015, 12, 12), "Arean Vermont", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "avermont", "123abc");
            Lawyer jl4 = new Lawyer(new DateTime(1996, 3, 26), 9, new DateTime(2015, 12, 12), "James Gordon", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "jgordon", "123abc");
            Lawyer jl5 = new Lawyer(new DateTime(1996, 3, 26), 10, new DateTime(2015, 12, 12), "Damian Wayne", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "dwayne", "123abc");
            Lawyer jl6 = new Lawyer(new DateTime(1996, 3, 26), 11, new DateTime(2015, 12, 12), "Alfred Pennyworth", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "apennyworth", "123abc");
            Lawyer jl7 = new Lawyer(new DateTime(1996, 3, 26), 12, new DateTime(2015, 12, 12), "Sam Fisher", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "sfisher", "123abc");
            Lawyer jl8 = new Lawyer(new DateTime(1996, 3, 26), 13, new DateTime(2015, 12, 12), "Amanda White", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "awhite", "123abc");
            Lawyer jl9 = new Lawyer(new DateTime(1996, 3, 26), 14, new DateTime(2015, 12, 12), "Clark Kent", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "ckent", "123abc");
            Lawyer jl10 = new Lawyer(new DateTime(1996, 3, 26), 15, new DateTime(2015, 12, 12), "Lois Lane", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "llane", "123abc");
            Lawyer jl11 = new Lawyer(new DateTime(1996, 3, 26), 16, new DateTime(2015, 12, 12), "Berry White", "fighting, kung-fu, driving", "family criminal, immigrant, etc", 3, false, "bwhite", "123abc");

            Data.employees.Add(jl1);
            Data.employees.Add(jl2);
            Data.employees.Add(jl3);
            Data.employees.Add(jl4);
            Data.employees.Add(jl5);
            Data.employees.Add(jl6);
            Data.employees.Add(jl7);
            Data.employees.Add(jl8);
            Data.employees.Add(jl9);
            Data.employees.Add(jl10);
            Data.employees.Add(jl11);

            Administration a1 = new Administration(17, "Jack Sparrow", new DateTime(1998, 6, 10), "Joking, Talking, Discussing, etc.", "System Administrator", "jsparrow", "123abc");
            Administration a2 = new Administration(18, "John Wick", new DateTime(1998, 6, 10), "Joking, Talking, Discussing, etc.", "System Administrator", "jwick", "123abc");
            Administration a3 = new Administration(19, "Hal Jordan", new DateTime(1998, 6, 10), "Joking, Talking, Discussing, etc.", "System Administrator", "hjordan", "123abc");
            Administration a4 = new Administration(20, "Barry Allen", new DateTime(1998, 6, 10), "Joking, Talking, Discussing, etc.", "System Administrator", "ballen", "123abc");
            Administration a5 = new Administration(21, "Diana Prince", new DateTime(1998, 6, 10), "Joking, Talking, Discussing, etc.", "System Administrator", "dprince", "123abc");

            Data.employees.Add(a1);
            Data.employees.Add(a2);
            Data.employees.Add(a3);
            Data.employees.Add(a4);
            Data.employees.Add(a5);

            Receptionist r1 = new Receptionist(22, "James Bond", new DateTime(2013, 12, 24), "shooting, fighting, talking", "jbond", "123abc");

            Data.employees.Add(r1);

            Console.WriteLine("Employee database has been set up successfully!");
        }

        public static void addNewClient() {

            try
            {
                int newClientID = -1;
                int clientCount = Data.clients.Count;

                if (clientCount > 0)
                {
                    newClientID = Data.clients[Data.clients.Count - 1].getId() + 1;
                }
                else
                {
                    newClientID = 1;
                }

                Console.Write("Enter client's first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter client's middle name: ");
                string middleName = Console.ReadLine();

                Console.Write("Enter client's last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter client's date of birth (MM/DD/YYYY): ");
                string dobString = Console.ReadLine();
                DateTime dob = Convert.ToDateTime(dobString);


                string caseType = "";

                while (!(caseType == "Corporate" || caseType == "Family" || caseType == "Criminal"))
                {
                    Console.Write("Enter client's case type: ");
                    caseType = Console.ReadLine();
                }

                Console.Write("Enter client's street: ");
                string street = Console.ReadLine();

                Console.Write("Enter client's street number: ");
                string streetNr = Console.ReadLine();

                Console.Write("Enter client's zip code: ");
                string zip = Console.ReadLine();

                Console.Write("Enter client's city: ");
                string city = Console.ReadLine();

                Client newClient = new Client(newClientID, firstName, middleName, lastName, dob, caseType, street, streetNr, zip, city);
                Data.clients.Add(newClient);
                Console.WriteLine("Add a new client successfully!");
            }
            catch (Exception e) {
                Console.WriteLine("Add a new client fail! " + e.Message);
            }

        }

        public static void getClientList() {
            Console.WriteLine("This is the list of clients: ");

            List<Client> clientsList = Data.clients;

            for (int i = 0; i < clientsList.Count; i++) {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine(clientsList[i].ToString());
                
            }
        }






    }
}
