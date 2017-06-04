using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDesignPatternTpp_Patern.Pages.ResizablePage
{
   public partial class ResizablePage : BasePage
    {

        public IWebElement Resizable_Button
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-1"));
            }
        }
        public IWebElement Resizable_Djijavka1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            }
        }
        public IWebElement Resizable_Elemnt1
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }

    }
}
