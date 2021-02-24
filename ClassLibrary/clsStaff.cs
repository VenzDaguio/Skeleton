using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public decimal Salary;
        public bool StaffID;

        public string StaffPosition { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
    }
}