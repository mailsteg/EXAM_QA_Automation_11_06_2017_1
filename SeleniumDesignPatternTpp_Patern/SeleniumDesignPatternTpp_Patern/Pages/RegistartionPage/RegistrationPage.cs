using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumDesignPatternTpp_Patern.Models;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDesignPatternTpp_Patern.Pages.RegistartionPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }
        public string  URL {
            get
            {
                return base.url + "registration/";
            }
                }

        public void NavigateTo()
        {
            
            this.Driver.Navigate().GoToUrl(this.URL);
            //  this.Wait.Until(ExpectedConditions.ElementExists(By.Name("pie_submit")));
            this.Driver.Manage().Window.Maximize();
        }

        
        public void FillRegistrationForm(RegistrationUser user)
        {
            Type(this.FirstName_Field, user.FirstName);
            Type(this.LastName_Field, user.LastName);          
            ClickOnElements(this.MaritalStatus_RadioButtons, user.MatrialStatus);
            ClickOnElements(this.Hobbys_Check_Boxes, user.Hobbys);
            this.CountryOption.SelectByText(user.Country);
            this.MounthOption.SelectByText(user.BirthMonth);
            this.DayOption.SelectByText(user.BirthDay);
            this.YearOption.SelectByText(user.BirthYear);
            Type(this.Phone_Field, user.Phone);
            Type(this.UserName_Field, user.UserName);
            Type(this.Email_Field, user.Email);
         // this.UploadButton.Click();
         // this.Driver.SwitchTo().ActiveElement().SendKeys(user.Picture);
            Type(this.Description, user.Description);
            Type(this.Password_Field, user.Password);
            Type(this.ConfirmPassword_Field, user.ConfirmPassword);
            this.SubmitButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {
                element.Clear();
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }

               
        }
        private void ClickOnElements(List<IWebElement> elements, string choice)
        {
            var conditions = choice.Split();
            for (int i = 0; i < conditions.Length - 1; i++)
            {
                if (!conditions[i].Equals("true"))
                {
                    elements[i].Click();
                }
            }
        }
    }
}
