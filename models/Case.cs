using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    class Case
    {
        private int id;
        private int customerId;
        private string caseType;
        private DateTime startDate;
        private string expectedProcessDuration;
        private double totalCharges;
        private int lawyerId;
        private string situationDescription;
        private string otherNotes;

        public Case(
            int id,
            int customerId,
            string caseType,
            DateTime startDate,
            string expectedProcessDuration,
            double totalCharges,
            int lawyerId,
            string situationDescription,
            string otherNotes)
        {
            this.id = id;
            this.customerId = customerId;

            if (!(caseType == "Corporate" || caseType == "Family" || caseType == "Criminal"))
            {
                throw new Exception("Invalid Case Type!");
            }
            else
            {
                this.caseType = caseType;
            }

            this.startDate = startDate;
            this.expectedProcessDuration = expectedProcessDuration;
            this.totalCharges = totalCharges;
            this.lawyerId = lawyerId;
            this.situationDescription = situationDescription;
            this.otherNotes = otherNotes;
        }

        public void setId(int id) {
            this.id = id;
        }

        public int getId() {
            return this.id;
        }

        public void setCustomerId(int customerId) {
            this.customerId = customerId;
        }

        public int getCustomerId() {
            return this.customerId;
        }

        public void setCaseType(string caseType) {
            if (!(caseType == "Corporate" || caseType == "Family" || caseType == "Criminal"))
            {
                throw new Exception("Invalid Case Type!");
            }
            else
            {
                this.caseType = caseType;
            }
        }

        public string getCaseType() {
            return this.caseType;
        }

        public void setStartDate(DateTime startDate) {
            this.startDate = startDate;
        }

        public DateTime getStartDate() {
            return this.startDate;
        }

        public void setExpectedProcessDuration(string expectedProcessDuration) {
            this.expectedProcessDuration = expectedProcessDuration;
        }

        public string getExpectedProcessDuration() {
            return this.expectedProcessDuration;
        }

        public void setTotalCharges(double totalCharges) {
            this.totalCharges = totalCharges;
        }

        public double getTotalCharges() {
            return this.totalCharges;
        }

        public void setLawyerId(int lawyerId) {
            this.lawyerId = lawyerId;
        }

        public int getLawyerId() {
            return this.lawyerId;
        }

        public void setSituationDescription(string situationDescription) {
            this.situationDescription = situationDescription;
        }

        public string getSituationDescription() {
            return this.situationDescription;
        }

        public void setOtherNotes(string otherNotes) {
            this.otherNotes = otherNotes;
        }

        public string getOtherNotes() {
            return this.otherNotes;
        }

        public override string ToString() {
            return "Id: " + this.id + "\n"
                + "Customer Id: " + this.customerId + "\n"
                + "Case type: " + this.caseType + "\n"
                + "Start date: " + this.startDate.ToString() + "\n"
                + "Expected process duration: " + this.expectedProcessDuration + "\n"
                + "Total charges: " + this.totalCharges + "\n"
                + "Lawyer Id" + this.lawyerId + "\n"
                + "Situation description: " + this.situationDescription + "\n"
                + "Other notes: " + this.otherNotes;
        }






    }
}
