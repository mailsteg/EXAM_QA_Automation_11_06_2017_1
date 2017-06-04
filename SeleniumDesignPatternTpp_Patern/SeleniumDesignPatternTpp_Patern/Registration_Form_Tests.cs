using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumDesignPatternTpp_Patern.Models;
using SeleniumDesignPatternTpp_Patern.Pages.Home_Page;
using SeleniumDesignPatternTpp_Patern.Pages.RegistartionPage;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SeleniumDesignPatternTpp_Patern
{
    [TestFixture]
    public class Registration_Form_Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void InitialRuns()
        {
            this.driver = new ChromeDriver();
     }
 [TearDown]
 public void EndOfAllTests()
 {
     this.driver.Quit();
 }
    


        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void NavigateToHomePage_Test_4()
        {
            Home_Page homeP = new Home_Page(this.driver);
            PageFactory.InitElements(driver, homeP);
            homeP.Navigate();
            Assert.IsTrue(homeP.Logo.Displayed);

        }



        [Test, Property("Priority", 1)]
        [Author("Todor Peshin")]
        public void RegistrationForm_NavigateToRegPage_Test_1()
        {
            RegistrationPage RegPage = new RegistrationPage(this.driver);
            RegPage.NavigateTo();
            Assert.IsTrue(RegPage.SubmitButton.Displayed);
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void Registration_Form_PassStrenght_15()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("stamat");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Very weak");

        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_CheckErrorMessageForFirstNname_Test_2()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            var user = AccessExcelData.GetTestData("stamat");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageFirstNamereqNegativ("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_CheckErrorMessageForLastNname_Test_3()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("lastname");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageFirstNamereqNegativ("* This field is required");
        }

        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_HobbyTest_5()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("hobby");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageHoobyReqNegative("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_PhoneRequiered_Test_6()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("phone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessagePhoneReq("* This field is required");
        }


        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_Phone10_Test_7()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("phone10");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessagePhone10Digits("* Minimum 10 Digits starting with Country Code");
        }

        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_UserName_Test_8()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("username");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageUserNameReq("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_EmailReqTest_9()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("email");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageEmailReq("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_InvalidEmail_10()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("invalidemail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageEmailReq("* Invalid email address");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_Passwordreq_11()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("password");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessagePasswordReq("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_Password8Dig_12()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("password8");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessagePasswordReq("* Minimum 8 characters required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_Confirm_Password_13()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("passwordconf");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertErrorMessageConfirmPasswordReq("* This field is required");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void RegistrationForm_ErrorMessage_Confirm_PasswordMatch_14()

        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("passwordmatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Mismatch");
        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void Registration_Form_PassStrenghtWeak_16()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("passweak");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Weak");

        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void Registration_Form_PassStrenghtMedium_17()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("stamatmedium");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Medium");

        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void Registration_Form_PassStrenghtStrong_18()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("stamatstrong");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Strong");

        }
        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void Registration_Form_PassStrenghtMismatch_19()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = AccessExcelData.GetTestData("passwordmatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(user);
            regPage.AssertStrenfght("Mismatch");
        }

        [Test, Property("Priority", 2)]
        [Author("Todor Peshin")]
        public void StrentIndicator_20()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);          
            regPage.NavigateTo();
            regPage.AssertStrenfght("Strength Indicator");
        }        
    }
}

                 