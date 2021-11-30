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
        public static bool isStop = false;
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
            Console.WriteLine("\n===========Client List==========");

            List<Client> clientsList = Data.clients;

            for (int i = 0; i < clientsList.Count; i++) {
                Console.WriteLine(clientsList[i].ToString());
                Console.WriteLine("=========");

            }
            Console.WriteLine("-----------------------------\n");
        }


        //show list of Lawyer
        public static void getLawyerList() {
            Console.WriteLine("\n===========Lawyer List==========");
            for (int i = 0; i < Data.employees.Count; i++) {
                if (Data.employees[i].getPosition() == "Lawyer") {
                    Lawyer currentLawyer = (Lawyer)Data.employees[i];

                    Console.WriteLine(currentLawyer.ToString());
                    Console.WriteLine("=========");
                }
            }
            Console.WriteLine("-----------------------------\n");
        }

        // add a new appointment
        public static void addNewAppointment() {
            try
            {
                int newAppointmentID = -1;
                int appointmentCount = Data.appointments.Count;

                if (appointmentCount > 0)
                {
                    newAppointmentID = Data.clients[Data.clients.Count - 1].getId() + 1;
                }
                else
                {
                    newAppointmentID = 1;
                }

                Console.WriteLine("Please choose a client, then input his/her ID below: ");
                getClientList();
                Console.Write("Your client ID is: ");
                int clientID = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please choose a lawyer, then input his/her ID below: ");
                getLawyerList();
                Console.Write("Your lawyer ID is: ");
                int lawyerID = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the meeting date & time (MM/DD/YYYY): ");
                string dateTimeString = Console.ReadLine();
                DateTime dateTime = Convert.ToDateTime(dateTimeString);

                Console.Write("Enter your meeting room: ");
                string meetingRoom = Console.ReadLine();

                Console.Write("Enter a short description about the appointment: ");
                string shortDescription = Console.ReadLine();

                Appointment newAppointment = new Appointment(newAppointmentID, clientID, lawyerID, dateTime, meetingRoom, shortDescription);
                Data.appointments.Add(newAppointment);
                Console.WriteLine("Add a new appointment successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Add a new appointment fail! " + e.Message);
            }
        }

        public static void getAppointmentList() {
            Console.WriteLine("\n===========Appointment List==========");
            for (int i = 0; i < Data.appointments.Count; i++)
            {
                Console.WriteLine(Data.appointments[i].ToString());
                Console.WriteLine("=========");  
            }
            Console.WriteLine("-----------------------------\n");
        }

        public static void addNewCase() {
            try
            {
                int newCaseID = -1;
                int casesCount = Data.cases.Count;

                if (casesCount > 0)
                {
                    newCaseID = Data.cases[Data.cases.Count - 1].getId() + 1;
                }
                else
                {
                    newCaseID = 1;
                }

                Console.WriteLine("Please choose a client, then input his/her ID below: ");
                getClientList();
                Console.Write("Your client ID is: ");
                int clientID = Int32.Parse(Console.ReadLine());

                string caseType = "";

                while (!(caseType == "Corporate" || caseType == "Family" || caseType == "Criminal"))
                {
                    Console.Write("Enter client's case type: ");
                    caseType = Console.ReadLine();
                }


                Console.Write("Enter the case start date (MM/DD/YYYY): ");
                string dateTimeString = Console.ReadLine();
                DateTime startDate = Convert.ToDateTime(dateTimeString);

                Console.Write("Enter your expected process duration: ");
                string expectedProcessDuration = Console.ReadLine();

                Console.Write("Enter total charge for this case(EUR): ");
                double totalCharge = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please choose a lawyer, then input his/her ID below: ");
                getLawyerList();
                Console.Write("Your lawyer ID is: ");
                int lawyerID = Int32.Parse(Console.ReadLine());

                Console.Write("Enter the case's situation description: ");
                string situationDescription = Console.ReadLine();

                Console.Write("Enter the case's other notes: ");
                string otherNotes = Console.ReadLine();

                Case newCase = new Case(newCaseID, clientID, caseType, startDate, expectedProcessDuration, totalCharge, lawyerID, situationDescription, otherNotes);
                Data.cases.Add(newCase);
                Console.WriteLine("Add a new case successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Add a new case fail! " + e.Message);
            }

            
        }

        public static void getCaseList()
        {
            Console.WriteLine("\n===========Case List==========");
            for (int i = 0; i < Data.cases.Count; i++)
            {
                Console.WriteLine(Data.cases[i].ToString());
                Console.WriteLine("=========");
            }
            Console.WriteLine("-----------------------------\n");
        }

        public static void logOut() {
            Data.currentUser = null;
            isStop = true;
        }

        public static void showOptions(string position) {

            int choice = -1;

            if (position == "Receptionist")
            {
                Console.WriteLine("\n** You are a receptionist, here are your options: \n");
                Console.WriteLine("1 - Register a new client.");
                Console.WriteLine("2 - Add a new appointment.");
                Console.WriteLine("3 - List all appointments.");
                Console.WriteLine("4 - List all clients.");
                Console.WriteLine("5 - Log out.");

                Console.Write("Enter your answer (1-5): ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    addNewClient();
                }
                else if (choice == 2)
                {
                    addNewAppointment();
                }
                else if (choice == 3)
                {
                    getAppointmentList();
                }
                else if (choice == 4)
                {
                    getClientList();
                }
                else {
                    logOut();
                }

                   
            }
            else if (position == "Lawyer")
            {
                Console.WriteLine("\n** You are a lawyer, here are your options: \n");
                Console.WriteLine("1 - List all cases.");
                Console.WriteLine("2 - Add a new case.");
                Console.WriteLine("3 - List all appointments.");
                Console.WriteLine("4 - Log out.");

                Console.Write("Enter your answer (1-4): ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    getCaseList();
                }
                else if (choice == 2)
                {
                    addNewCase();
                }
                else if (choice == 3)
                {
                    getAppointmentList();
                }
                else
                {
                    logOut();
                }
            }
            else 
            {
                Console.WriteLine("\n** You are an admin, here are your options: \n");
                Console.WriteLine("1 - List all cases.");
                Console.WriteLine("2 - List all appointments.");
                Console.WriteLine("3 - Log out.");

                Console.Write("Enter your answer (1-3): ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    getCaseList();
                }
                else if (choice == 2)
                {
                    getAppointmentList();
                }
                else
                {
                    logOut();
                }
            }

        

        }

        public static void processing() {
            setUpEmployees();

            logIn();
            while (!isStop) {
                showOptions(Data.currentUser.getPosition());
            }
        }



    }
}
