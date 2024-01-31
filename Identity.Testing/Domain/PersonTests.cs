using Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Testing.Domain
{
    public class PersonTests
    {
        [Fact]
        public void NameFull_Validate_Valid()
        {
            // Arrange
            var person = new Person();

            // Act
            person.NameFull_Validate = "John Doe";

            // Assert
            Assert.Equal("John Doe", person.NameFull);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void NameFull_Validate_Invalid(string invalidName)
        {
            // Arrange
            var person = new Person();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => person.NameFull_Validate = invalidName);
        }

        [Fact]
        public void Age_Validate_Valid()
        {
            // Arrange
            var person = new Person();

            // Act
            person.Age_Validate = 18;

            // Assert
            Assert.Equal(18, person.Age);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(0)]
        [InlineData(-5)]
        public void Age_Validate_Invalid(int invalidAge)
        {
            // Arrange
            var person = new Person();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => person.Age_Validate = invalidAge);
        }

        [Fact]
        public void Gender_Validate_Valid()
        {
            // Arrange
            var person = new Person();

            // Act
            person.Gender_Validate = "Male";

            // Assert
            Assert.Equal("Male", person.Gender);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Gender_Validate_Invalid(string invalidGender)
        {
            // Arrange
            var person = new Person();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => person.Gender_Validate = invalidGender);
        }

        [Fact]
        public void DateOfBirth_Validate_Valid()
        {
            // Arrange
            var person = new Person();

            // Act
            person.DateOfBirth_Validate = DateTime.Now.AddYears(-25);

            // Assert
            Assert.NotEqual(DateTime.MinValue, person.DateOfBirth);
        }

        [Fact]
        public void DateOfBirth_Validate_Invalid()
        {
            // Arrange
            var person = new Person();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => person.DateOfBirth_Validate = DateTime.MinValue);
        }
    }
}
