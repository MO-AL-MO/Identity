using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Identity.Domain.Entities
{
    public class Passport:BaseIdentity
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string PlaceOfIssue { get; set; }
        public override int Number { get; set; }
        public override DateTime ReleaseDate { get; set; }
        public override DateTime ExpiryDate { get; set; }
        public override string Barcode { get; set; }

        //=========================================================
        public string Type { get; set; }
        public string Nationality { get; set; }
        public string Job { get; set; }
        public Person Person {  get; set; }

        //----------------- Validation -----------------

        public string Type_Validate
        {
            get => Type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Type is required");
                }
                Type = value;
            }
        }
         public string Nationality_Validate
        {
            get => Nationality;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nationality is required");
                }
                Nationality = value;
            }
        }
        public string Job_Validate
        {
            get => Job;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Job is required");
                }
                Job = value;
            }
        }

        public IEnumerable<string> ValidateEntity()
        {
            var ErrorMessage = new List<string>();

            //if (Id_Validate < 0)
            //{
            //    ErrorMessage.Add("[ Id ] It must be bigger than snow");
            //}
            if (string.IsNullOrWhiteSpace(Name_Validate))
            {
                ErrorMessage.Add("[ Name ] is required");
            }
            if (string.IsNullOrWhiteSpace(PlaceOfIssue_Validate))
            {
                ErrorMessage.Add("[ PlaceOfIssue ] is required");
            }
            if (Number_Validate < 10000)
            {
                ErrorMessage.Add(" [ Number ] is required and must be a positive number with at least five digits");
            }
            if (ReleaseDate_Validate == DateTime.MinValue)
            {
                ErrorMessage.Add("[ ReleaseDate ] is required");
            }
            if (ExpiryDate_Validate == DateTime.MinValue)
            {
                ErrorMessage.Add("[ ExpiryDate ] is required");
            }
            if (string.IsNullOrWhiteSpace(Barcode_Validate))
            {
                ErrorMessage.Add("[ Barcode ] is required");
            }
            //=========================================================
            if (string.IsNullOrWhiteSpace(Type_Validate))
            {
                ErrorMessage.Add("[ Type ] is required");
            }
            if (string.IsNullOrWhiteSpace(Nationality_Validate))
            {
                ErrorMessage.Add("[ Nationality ] is required");
            }
            if (string.IsNullOrWhiteSpace(Job_Validate))
            {
                ErrorMessage.Add("[ Job ] is required");
            }
            //----------------- Validation Person -----------------
            if (string.IsNullOrWhiteSpace(Person.NameFull_Validate))
            {
                ErrorMessage.Add("[ NameFull ] is required");
            }
            if (Person.Age_Validate < 13)
            {
                ErrorMessage.Add(" [ Age ]  is required and The age must be more than thirteen years");
            }
            if (string.IsNullOrWhiteSpace(Person.Gender_Validate))
            {
                ErrorMessage.Add("[ Gender ] is required");
            }
            if (Person.DateOfBirth_Validate == DateTime.MinValue)
            {
                ErrorMessage.Add("[ DateOfBirth ] is required");
            }

            return ErrorMessage;
        }

    }
} 


