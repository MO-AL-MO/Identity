using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Testing.Domain
{
    public class BaseIdentityTests
    {
        [Fact]
        public void Name_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity(); // Assuming there's a class DerivedIdentity that inherits from BaseIdentity

            // Act
            baseIdentity.Name_Validate = "John Doe";

            // Assert
            Assert.Equal("John Doe", baseIdentity.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Name_Validate_Invalid(string invalidName)
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.Name_Validate = invalidName);
        }

        [Fact]
        public void PlaceOfIssue_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act
            baseIdentity.PlaceOfIssue_Validate = "City";

            // Assert
            Assert.Equal("City", baseIdentity.PlaceOfIssue);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void PlaceOfIssue_Validate_Invalid(string invalidPlaceOfIssue)
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.PlaceOfIssue_Validate = invalidPlaceOfIssue);
        }

        [Fact]
        public void Number_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act
            baseIdentity.Number_Validate = 20000;

            // Assert
            Assert.Equal(20000, baseIdentity.Number);
        }

        [Theory]
        [InlineData(10000)]
        [InlineData(0)]
        [InlineData(-5)]
        public void Number_Validate_Invalid(int invalidNumber)
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.Number_Validate = invalidNumber);
        }

        [Fact]
        public void ReleaseDate_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act
            baseIdentity.ReleaseDate_Validate = DateTime.Now;

            // Assert
            Assert.NotEqual(DateTime.MinValue, baseIdentity.ReleaseDate);
        }

        [Fact]
        public void ReleaseDate_Validate_Invalid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.ReleaseDate_Validate = DateTime.MinValue);
        }

        [Fact]
        public void ExpiryDate_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act
            baseIdentity.ExpiryDate_Validate = DateTime.Now.AddYears(5);

            // Assert
            Assert.NotEqual(DateTime.MinValue, baseIdentity.ExpiryDate);
        }

        [Fact]
        public void ExpiryDate_Validate_Invalid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.ExpiryDate_Validate = DateTime.MinValue);
        }

        [Fact]
        public void Barcode_Validate_Valid()
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act
            baseIdentity.Barcode_Validate = "123456";

            // Assert
            Assert.Equal("123456", baseIdentity.Barcode);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Barcode_Validate_Invalid(string invalidBarcode)
        {
            // Arrange
            var baseIdentity = new DerivedIdentity();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => baseIdentity.Barcode_Validate = invalidBarcode);
        }
    }

    // A derived class to test the abstract BaseIdentity
    public class DerivedIdentity : BaseIdentity
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string PlaceOfIssue { get; set; }
        public override int Number { get; set; }
        public override DateTime ReleaseDate { get; set; }
        public override DateTime ExpiryDate { get; set; }
        public override string Barcode { get; set; }
    }
    }
