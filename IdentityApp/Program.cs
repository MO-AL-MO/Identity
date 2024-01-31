using Identity.Domain.Entities;
using System.Reflection;

// إنشاء كائن من الفئة Passport
Passport passport = new Passport
{
    Name = "John Doe",
    PlaceOfIssue = "",
    Number = 12345,
    ReleaseDate = DateTime.Now,
    ExpiryDate = DateTime.Now.AddYears(5),
    Barcode = "ABC123",
    Type = "SomeType",
    Nationality = "",
    Job = "SomeJob",
    Person = new Person
    {
        NameFull = "John Doe",
        Age = -1,
        Gender = "Male",
        DateOfBirth = DateTime.Parse("1999-01-01")
    }
};

// التحقق من صحة البيانات
var validationErrors = passport.ValidateEntity();

// عرض نتائج التحقق من الصحة
if (validationErrors.Any())
{
    Console.WriteLine("Validation Errors:Passport");
    foreach (var error in validationErrors)
    {
        Console.WriteLine($"- {error}");
    }
}
else
{
    Console.WriteLine("Passport- Validation Passed!");
}
Console.WriteLine("=========================================================");
//=========================================================
// إنشاء كائن من الفئة IdentificationCard
IdentificationCard idCard = new IdentificationCard
{
    Name_Validate = "John Doe",
    PlaceOfIssue_Validate = "City",
    Number_Validate = 12345,
    ReleaseDate_Validate = DateTime.Now,
    ExpiryDate_Validate = DateTime.Now.AddYears(5),
    Barcode_Validate = "ABC123",
    BloodType_Validate = "A+",
    PhotoUrl_Validate = "https://example.com/photo.jpg",
    Person = new Person
    {
        NameFull_Validate = "John Doe",
        Age_Validate = 25,
        Gender_Validate = "Male",
        DateOfBirth_Validate = DateTime.Now.AddYears(-25)
    }
};

// التحقق من صحة البيانات
var validationErrors1 = idCard.ValidateEntity();

// عرض نتائج التحقق من الصحة
if (validationErrors1.Any())
{
    Console.WriteLine("Validation Errors:IdentificationCard");
    foreach (var error in validationErrors1)
    {
        Console.WriteLine($"- {error}");
    }
}
else
{
    Console.WriteLine("IdentificationCard: Validation Passed!");
}



