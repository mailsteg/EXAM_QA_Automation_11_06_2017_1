using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11_06_2017_Todor_Peshin.Pages.Home_Page
{
    public partial class Home_Page : BasePage
    {
        public Home_Page(IWebDriver driver) : base(driver)
        {
         
        }
        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl("http://softuni.bg/");
            Driver.Manage().Window.Maximize();
        }
    }
}
