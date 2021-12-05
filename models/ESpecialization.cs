using System;
using System.Collections.Generic;
using System.Text;

namespace LawyerCompanyProject.models
{
    enum ESpecialization
    {
        Family,
        Criminal,
        Corporate
    }

    class ESpecializationHelper
    {
        public static string getESpecializationValue(ESpecialization spec) {
            if (spec == ESpecialization.Family)
            {
                return "Family";
            }
            else if (spec == ESpecialization.Criminal) {
                return "Criminal";
            } else {
                return "Corporate";
            }
        }

        public static ESpecialization getESpecializationFromString(string spec) {
            if (spec == "Family")
            {
                return ESpecialization.Family;
            }
            else if (spec == "Criminal")
            {
                return ESpecialization.Criminal;
            }
            else {
                return ESpecialization.Corporate;
            }
        }

        
    }
}
