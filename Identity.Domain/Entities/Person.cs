using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Identity.Domain.Entities
{
    public class Person
    {
        private string NameFull { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        //----------------- Validation -----------------

        public string NameFull_Validate
        {
            get => NameFull;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("NameFull is required");
                }
                NameFull = value;
            }
        }

        public int Age_Validate
        {
            get => Age;
            set
            {
                if (value <= 13)
                {
                    throw new ArgumentException("Age is required and The age must be more than thirteen years");
                }


                Age = value;
            }
        }

        public string Gender_Validate
        {
            get => Gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gender is required");
                }
                Gender = value;
            }
        }

        public DateTime DateOfBirth_Validate
        {
            get => DateOfBirth;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("DateOfBirth is required");
                }
                DateOfBirth = value;
            }
        }



    }
}
