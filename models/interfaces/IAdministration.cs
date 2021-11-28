using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models.interfaces
{
    interface IAdministration : IEmployee
    {
        public void setRole(string role);
        public string getRole();
    }
}
