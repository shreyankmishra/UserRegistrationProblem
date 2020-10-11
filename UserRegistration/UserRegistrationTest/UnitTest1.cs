using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void FistNameTest()
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string firstName = "Shreyank";
                //Act
                bool result = user.ValidateFirstName(firstName);
                //Assert
                Assert.IsTrue(result);
            }
            [TestMethod]
            public void LastNameTest()
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string lastName = "Mishra";
                //Act
                bool result = user.ValidateLastName(lastName);
                //Assert
                Assert.IsTrue(result);
            }
            [TestMethod]
            public void EmailIdTest()
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string email = "mishra.shreyank@gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
                //Assert
                Assert.IsTrue(result);
            }
            [TestMethod]
            public void MobileNumberTest()
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string mobileNumber = "91 7598624310";
                //Act
                bool result = user.ValidateMobileNo(mobileNumber);
                //Assert
                Assert.IsTrue(result);
            }
            [TestMethod]
            public void PasswordTest()
            {
                //Arrange
                RegexValidate user = new RegexValidate();
                string password = "SAmmy@StRiker1";
                //Act
                bool result = user.ValidatePassword(password);
                //Assert
                Assert.IsTrue(result);
            }
        }
}
