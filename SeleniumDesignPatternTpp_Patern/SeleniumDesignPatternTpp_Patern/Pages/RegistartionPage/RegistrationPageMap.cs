using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternTpp_Patern.Pages.RegistartionPage
{
    public partial class RegistrationPage : BasePage

    {
        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.TagName("title"));
            }
        }
        public IWebElement Header
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("entry-title"));
            }
        }
        public IWebElement FirstName_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("name_3_firstname"));
            }
        }
        public IWebElement LastName_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("name_3_lastname"));
            }
        }
        public List<IWebElement> MaritalStatus_RadioButtons
        {
            get
            {
                return this.Driver.FindElements(By.Name("radio_4[]")).ToList();
            }
        }
        public List<IWebElement> Hobbys_Check_Boxes
        {
            get
            {
                return this.Driver.FindElements(By.Name("checkbox_5[]")).ToList();
            }
        }

        private IWebElement CountryDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("dropdown_7"));
            }
        }
        public SelectElement CountryOption
        {
            get
            {
                return new SelectElement(CountryDD);
            }
        }
        private IWebElement MounthDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("mm_date_8"));
            }
        }

        public SelectElement MounthOption
        {
            get
            {
                return new SelectElement(MounthDD);
            }
        }

        private IWebElement DayDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("dd_date_8"));
            }
        }
        public SelectElement DayOption
        {
            get
            {
                return new SelectElement(DayDD);
            }
        }

        private IWebElement YearDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("yy_date_8"));
            }
        }

        public SelectElement YearOption
        {
            get
            {
                return new SelectElement(YearDD);
            }
        }
        public IWebElement Phone_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("phone_9"));
            }
        }

        public IWebElement UserName_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("username"));
            }
        }

        public IWebElement Email_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("email_1"));
            }
        }
        public IWebElement UploadButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("profile_pic_10"));
            }
        }
        public IWebElement Description
        {
            get
            {
                return this.Driver.FindElement(By.Id("description"));
            }
        }
        public IWebElement Password_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("password_2"));
            }
        }
        public IWebElement ConfirmPassword_Field
        {
            get
            {
                return this.Driver.FindElement(By.Id("confirm_password_password_2"));
            }
        }
        public IWebElement SubmitButton
        {
            get
            {
                return this.Driver.FindElement(By.Name("pie_submit"));
            }
        }
        public IWebElement SuccessMessage
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("piereg_message"));
            }
        }
        public IWebElement ErrorMessagesForNames_fieldReq
        {
            get
            {                                                              
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
            }
        }

        public IWebElement ErrorMessagesForPhone
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesHobbyReq
        {
            get
            {                                                             
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span")));
                return this.Driver.FindElement(By.XPath( "//*[@id=\"pie_register\"]/li[3]/div/div[2]/span"));
            }
        }
        public IWebElement ErrorMessagesPhoneReq
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesPhone10Digits
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesUserNameFieldReq
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[7]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[7]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesEmailFieldReq
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesInvalidEmailField
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesPasswordMin8Digits
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesPasswordReq
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesConfirmPasswordReq
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagesConfirmPasswordNotMatch
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            }
        }
        public IWebElement Strength_Indicator
        {
            get
            {              
                return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
            }
        }

        public IWebElement LogoGator
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/header/div/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div/header/div/a"));
            }
        }
    }
}
