using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using LoginSystem.Domain;

namespace LoginSystemTest.DomainTests
{
    public class LoginUnitTest
    {
        private LoginValidations _loginValidations = new LoginValidations();

        [Theory]// Arrange
        [InlineData("test@myemail.com",true)]
        [InlineData("test@myemail.com#",false)]
        [InlineData("testmyemail.com",false)]
        [InlineData("test@myemailgov",false)]
        [InlineData("test@myemail.gov",true)]
        [InlineData("test_1@myemail.gov",true)]
        [InlineData("test.test@myemail.gov",true)]
        [InlineData("test.1@myemail.gov",true)]
        [InlineData("test_*@myemail.gov",false)]
        [InlineData(null,false)]
        [InlineData("",false)]
        public void ValidEmailsUsersList(string email, bool expected)
        {
            // Act
            var result = _loginValidations.ValidateEmail(email);

            // Assert
            if(expected){
                Assert.True(result);
            }else{
                Assert.False(result);
            }
        }

        [Theory]// Arrange
        [InlineData("2005@Tests",true)]
        [InlineData("test1Tcom*",true)]
        [InlineData("test1tcom*",false)]
        [InlineData("2005@Te",false)]//less than 8 characters
        [InlineData("test@myemail.com#",false)]//does not accept the # character
        [InlineData("test1Tcom",false)]//without special character
        [InlineData("test1t@com1",false)]//without capital letters
        [InlineData("TESTE1T@COM1",false)]//without lowercase letter
        [InlineData("testT@com",false)]//without NUMBER 
        [InlineData(null,false)]
        [InlineData("",false)]
        public void ValidPasswordUsersList(string password, bool expected)
        {
            // Act
            var result = _loginValidations.ValidatePassword(password);

            // Assert
            if(expected){
                Assert.True(result);
            }else{
                Assert.False(result);
            }
        }
    }
}