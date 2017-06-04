using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDesignPatternTpp_Patern.Pages.SelectablePage
{
   public partial class SelectablePage : BasePage
    {
        public IWebElement SelectableElement1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[1]"));
            }
        }
        public IWebElement SelectableElement2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[2]"));
            }
        }
        public IWebElement SelectableElement3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[3]"));
            }
        }
    }
}
