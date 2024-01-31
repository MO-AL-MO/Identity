using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Testing.Domain
{
    public class IdentificationCardTests
    {
        [Fact]
        public void BloodType_Validate_Valid()
        {
            // Arrange
            var identificationCard = new IdentificationCard();

            // Act
            identificationCard.BloodType_Validate = "A+";

            // Assert
            Assert.Equal("A+", identificationCard.BloodType);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void BloodType_Validate_Invalid(string invalidBloodType)
        {
            // Arrange
            var identificationCard = new IdentificationCard();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => identificationCard.BloodType_Validate = invalidBloodType);
        }

        [Fact]
        public void PhotoUrl_Validate_Valid()
        {
            // Arrange
            var identificationCard = new IdentificationCard();

            // Act
            identificationCard.PhotoUrl_Validate = "https://example.com/photo.jpg";

            // Assert
            Assert.Equal("https://example.com/photo.jpg", identificationCard.PhotoUrl);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void PhotoUrl_Validate_Invalid(string invalidPhotoUrl)
        {
            // Arrange
            var identificationCard = new IdentificationCard();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => identificationCard.PhotoUrl_Validate = invalidPhotoUrl);
        }

        [Fact]
        public void ValidateEntity_AllValid()
        {
            // Arrange
            var identificationCard = new IdentificationCard
            {
                Name_Validate = "John Doe",
                PlaceOfIssue_Validate = "City",
                Number_Validate = 20000,
                ReleaseDate_Validate = DateTime.Now,
                ExpiryDate_Validate = DateTime.Now.AddYears(5),
                Barcode_Validate = "123456",
                BloodType_Validate = "A+",
                PhotoUrl_Validate = "https://example.com/photo.jpg",
                Person = new Person
                {
                    NameFull_Validate = "John Doe",
                    Age_Validate = 18,
                    Gender_Validate = "Male",
                    DateOfBirth_Validate = DateTime.Now.AddYears(-18)
                }
            };

            // Act
            var errors = identificationCard.ValidateEntity();

            // Assert
            Assert.Empty(errors);
        }

        // Add more tests for ValidateEntity with different invalid scenarios
    }
}
