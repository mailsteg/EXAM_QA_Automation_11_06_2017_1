using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternTpp_Patern.Pages.Home_Page
{
   public partial class Home_Page : BasePage
    {
       
        public Home_Page(IWebDriver driver)
            :base(driver)
        {         
        }
        // [FindsBy (How = How.XPath, Using = "//*[@id=\"menu-item-374\"]/a")]
        //  public IWebElement RegistrationButton { get; set; }
        //
        // [FindsBy(How= How.XPath, Using = "//*[@id=\"site_navigation\"]/div/div[1]/a/img")]
        //  public IWebElement Logo { get; set; }
        //
        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl("http://www.demoqa.com");
            Driver.Manage().Window.Maximize();
        }
    }
}
