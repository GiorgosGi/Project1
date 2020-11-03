﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student
    {
        private string _firstname;
        private string _lastname;
        private string _dateofbirth;
        private string _tuitionfees;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }

        public string DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value.ToUpper(); }
        }

        public string TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value.ToUpper(); }
        }

        public override string ToString()      
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of Birth: {_dateofbirth}\tTuition fees: {_tuitionfees}");
        }
    }

    
}
