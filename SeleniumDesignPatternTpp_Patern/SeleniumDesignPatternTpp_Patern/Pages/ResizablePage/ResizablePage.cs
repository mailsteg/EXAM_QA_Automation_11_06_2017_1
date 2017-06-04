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
        public ResizablePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
