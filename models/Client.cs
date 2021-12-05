using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Client
    {
        private int id;
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dob;
        private ESpecialization caseType;
        private string street;
        private string streetNr;
        private string zip;
        private string city;

        public Client(
            int id,
            string firstName,
            string middleName,
            string lastName,
            DateTime dob,
            ESpecialization caseType,
            string street,
            string streetNr,
            string zip,
            string city) {

            this.id = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dob = dob;

            if (!(caseType == ESpecialization.Corporate || caseType == ESpecialization.Criminal || caseType == ESpecialization.Family))
            {
                throw new Exception("Invalid Case Type!");
            }
            else
            {
                this.caseType = caseType;
            }

            this.street = street;
            this.streetNr = streetNr;
            this.zip = zip;
            this.city = city;
        }

        public void setId(int id) {
            this.id = id;
        }

        public int getId() {
            return this.id;
        }

        public void setFirstName(string firstName) {
            this.firstName = firstName;
        }

        public string getFirstName() {
            return this.firstName;
        }

        public void setMiddleName(string middleName) {
            this.middleName = middleName;
        }

        public string getMiddleName() {
            return this.middleName;
        }

        public void setLastName(string lastName) {
            this.lastName = lastName;
        }

        public string getLastName() {
            return this.lastName;
        }

        public void setDOB(DateTime dob) {
            this.dob = dob;
        }

        public DateTime getDOB() {
            return this.dob;
        }

        public void setCaseType(ESpecialization caseType) {
            if (!(caseType == ESpecialization.Family || caseType == ESpecialization.Corporate || caseType == ESpecialization.Criminal))
            {
                throw new Exception("Invalid Case Type!");
            }
            else
            {
                this.caseType = caseType;
            }
        }

        public ESpecialization getCaseType() {
            return this.caseType;
        }

        public void setStreet(string street) {
            this.street = street;
        }

        public string getStreet() {
            return this.street;
        }

        public void setStreetNr(string streetNr) {
            this.streetNr = streetNr;
        }

        public string getStreetNr() {
            return this.streetNr;
        }

        public void setZip(string zip) {
            this.zip = zip;
        }

        public string getZip() {
            return this.zip;
        }

        public void setCity(string city) {
            this.city = city;
        }

        public string getCity() {
            return this.city;
        }

        public override string ToString()
        {
            return "ID: " + this.id + "\n"
                + "First Name: " + this.firstName + "\n"
                + "Middle Name: " + this.middleName + "\n"
                + "Last Name: " + this.lastName + "\n"
                + "Date of birth: " + this.dob.ToString() + "\n"
                + "Case type: " + ESpecializationHelper.getESpecializationValue(caseType) + "\n"
                + "Street: " + this.street + "\n"
                + "Street number: " + this.streetNr + "\n"
                + "Zip: " + this.zip + "\n"
                + "City: " + this.city;

        }

    }
}
