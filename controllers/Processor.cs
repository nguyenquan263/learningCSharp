using LawyerCompanyProject.models;
using LawyerCompanyProject.models.interfaces;
using LawyerCompanyProject.statics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LawyerCompanyProject.controllers
{
    class Processor
    {
        public static bool isStop = false;
        public static bool logIn()
        {
            int trialTime = 3;

            
            while (trialTime > 0)
            {
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
            //for lawyers
            string[] fileContents = File.ReadAllLines(@"lawyers.csv");
            for (int i = 0; i < fileContents.Length; i++)
            {
                if (i > 0)
                {
                    string[] currentLine = fileContents[i].Split(',');
                 

                    DateTime dob = Convert.ToDateTime(currentLine[0]);
                    int id = Int32.Parse(currentLine[1]);
                    DateTime joinedDate = Convert.ToDateTime(currentLine[2]);
                    string name = currentLine[3];
                    string otherExpertise = currentLine[4];
                    string specialization = currentLine[5];
                    int yearOfExperience = Int32.Parse(currentLine[6]);
                    bool isSenior = false;
                    if (currentLine[7] == "Yes")
                    {
                        isSenior = true;
                    }
                    string username = currentLine[8];
                    string password = currentLine[9];
                    Lawyer newLawyer = new Lawyer(dob, id, joinedDate, name, otherExpertise, specialization, yearOfExperience, isSenior, username, password);
                    Data.employees.Add(newLawyer);
                }
            }

            //for admins
            fileContents = File.ReadAllLines(@"admins.csv");
            for (int i = 0; i < fileContents.Length; i++) {
                if (i > 0) {
                    string[] currentLine = fileContents[i].Split(',');
                    int id = Int32.Parse(currentLine[0]);
                    DateTime joinedDate = Convert.ToDateTime(currentLine[1]);
                    string name = currentLine[2];
                    string otherExpertise = currentLine[3];
                    string role = currentLine[4];
                    string userName = currentLine[5];
                    string password = currentLine[6];

                    Administration newAdmin = new Administration(id, name, joinedDate, otherExpertise, role, userName, password);
                    Data.employees.Add(newAdmin);
                }
            }

            fileContents = File.ReadAllLines(@"receptionists.csv");
            for (int i = 0; i < fileContents.Length; i++)
            {
                if (i > 0)
                {
                    string[] currentLine = fileContents[i].Split(',');
                    int id = Int32.Parse(currentLine[0]);
                    DateTime joinedDate = Convert.ToDateTime(currentLine[1]);
                    string name = currentLine[2];
                    string otherExpertise = currentLine[3];
                    string userName = currentLine[4];
                    string password = currentLine[5];

                    Receptionist newAdmin = new Receptionist(id, name, joinedDate, otherExpertise, userName, password);
                    Data.employees.Add(newAdmin);
                }
            }

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

            Console.Write("Do you want to exit the application? (Y/N)");
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("y"))
            {
                System.Environment.Exit(0);
            }
            else {
                logIn();
            }

            
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
