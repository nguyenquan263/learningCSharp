using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models.interfaces
{
    interface ILawyer : IEmployee
    {
        public abstract bool isSenior();
        public abstract void setSenior();
    }
}
