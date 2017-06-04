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
        public SelectablePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
