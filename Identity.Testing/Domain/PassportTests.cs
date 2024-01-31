using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Testing.Domain
{
    public class PassportTests
    {
        [Fact]
        public void Type_Validate_Valid()
        {
            // Arrange
            var passport = new Passport();

            // Act
            passport.Type_Validate = "Tourist";

            // Assert
            Assert.Equal("Tourist", passport.Type);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Type_Validate_Invalid(string invalidType)
        {
            // Arrange
            var passport = new Passport();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => passport.Type_Validate = invalidType);
        }

        [Fact]
        public void Nationality_Validate_Valid()
        {
            // Arrange
            var passport = new Passport();

            // Act
            passport.Nationality_Validate = "USA";

            // Assert
            Assert.Equal("USA", passport.Nationality);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Nationality_Validate_Invalid(string invalidNationality)
        {
            // Arrange
            var passport = new Passport();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => passport.Nationality_Validate = invalidNationality);
        }

        [Fact]
        public void Job_Validate_Valid()
        {
            // Arrange
            var passport = new Passport();

            // Act
            passport.Job_Validate = "Engineer";

            // Assert
            Assert.Equal("Engineer", passport.Job);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Job_Validate_Invalid(string invalidJob)
        {
            // Arrange
            var passport = new Passport();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => passport.Job_Validate = invalidJob);
        }

        [Fact]
        public void ValidateEntity_AllValid()
        {
            // Arrange
            var passport = new Passport
            {
                Name_Validate = "John Doe",
                PlaceOfIssue_Validate = "City",
                Number_Validate = 20000,
                ReleaseDate_Validate = DateTime.Now,
                ExpiryDate_Validate = DateTime.Now.AddYears(5),
                Barcode_Validate = "123456",
                Type_Validate = "Tourist",
                Nationality_Validate = "USA",
                Job_Validate = "Engineer",
                Person = new Person
                {
                    NameFull_Validate = "John Doe",
                    Age_Validate = 18,
                    Gender_Validate = "Male",
                    DateOfBirth_Validate = DateTime.Now.AddYears(-18)
                }
            };

            // Act
            var errors = passport.ValidateEntity();

            // Assert
            Assert.Empty(errors);
        }

        // Add more tests for ValidateEntity with different invalid scenarios
    }
}
