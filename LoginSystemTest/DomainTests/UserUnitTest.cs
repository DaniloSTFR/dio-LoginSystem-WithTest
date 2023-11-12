using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using LoginSystem.Domain;

namespace LoginSystemTest.DomainTests
{
    public class UserUnitTest
    {
        private UserValidations _userValidations = new UserValidations();

        [Theory]// Arrange
        [InlineData("Test",true)]
        [InlineData("Test Test",true)]
        [InlineData("Test1",false)]
        [InlineData("Test@",false)]
        [InlineData("Test Test's",true)]
        [InlineData("Di-Test Test's",true)]
        [InlineData(null,false)]
        [InlineData("",false)]
        public void ValidNamesUsersList(string name, bool expected)
        {
            // Act
            var result = _userValidations.ValidateName(name);

            // Assert
            if(expected){
                Assert.True(result);
            }else{
                Assert.False(result);
            }
        }

        [Theory]// Arrange
        [InlineData("2023-11-12",true)]
        [InlineData("23-11-12",false)]
        [InlineData("11-12-2023",false)]
        [InlineData("11-12-23",false)]
        [InlineData(null,false)]
        [InlineData("",false)]
        public void ValidateBirthDate(string birthDate, bool expected)
        {
            // Act
            var result = _userValidations.ValidateBirthDate(birthDate);

            // Assert
            if(expected){
                Assert.True(result);
            }else{
                Assert.False(result);
            }
        }

        [Theory]// Arrange
        [InlineData(0,true)]
        [InlineData(1,true)]
        [InlineData(2,true)]
        [InlineData(3,true)]
        [InlineData(4,false)]

        public void ValidateIsPositionExists(int position, bool expected)
        {
            // Act
            var result = _userValidations.IsPositionExists(position);

            // Assert
            if(expected){
                Assert.True(result);
            }else{
                Assert.False(result);
            }
        }
    }
}