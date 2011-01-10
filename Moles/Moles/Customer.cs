using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moles
{
    public class Customer
    {
        public DateTime DateOfBirth { get; set; }

        public Customer(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public bool IsMinor()
        {
            if (CalculateAge() < 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int CalculateAge()
        {
            var now = DateTime.Today;

            return (now - DateOfBirth).Days/365;

            #region Alternate Algorithm
            /*
            var years = now.Year - DateOfBirth.Year;

            if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day))
            {
                years--;
            }

            return years;
            */
            #endregion
        }
    }
}
