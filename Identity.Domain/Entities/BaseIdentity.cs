using Entity.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Entities
{
    public abstract class BaseIdentity
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string PlaceOfIssue { get; set; }
        public abstract int Number { get; set; }
        public abstract DateTime ReleaseDate { get; set; }
        public abstract DateTime ExpiryDate { get; set; }
        public abstract string Barcode { get; set; }
       
        
        //----------------- Validation -----------------
        //public int Id_Validate
        //{
        //    get => Id;
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            throw new ArgumentException("Id must be greater than 0");
        //        }
        //        Id = value;
        //    }
        //}
        public string Name_Validate
        {
            get => Name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is required");
                }
                Name = value;
            }
        }
        public string PlaceOfIssue_Validate
        {
            get => PlaceOfIssue;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("PlaceOfIssue is required");
                }
                PlaceOfIssue = value;
            }
        }
        public int Number_Validate
        {
            get => Number;
            set
            {
                if (value <= 10000)
                {
                    throw new ArgumentException("Number is required and must be a positive number with at least five digits");
                }


                Number = value;
            }
        }
        public DateTime ReleaseDate_Validate
        {
            get => ReleaseDate;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("ReleaseDate is required");
                }
                ReleaseDate = value;
            }
        }
        public DateTime ExpiryDate_Validate
        {
            get => ExpiryDate;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("ExpiryDate is required");
                }
                ExpiryDate = value;
            }
        }
        public string Barcode_Validate
        {
            get => Barcode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("BarcodeData is required");
                }
                Barcode = value;
            }
            }

        }
}

