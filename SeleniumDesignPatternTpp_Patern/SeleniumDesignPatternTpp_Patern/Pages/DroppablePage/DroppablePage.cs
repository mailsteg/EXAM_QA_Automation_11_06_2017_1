
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumDesignPatternTpp_Patern.Pages.DroppablePage
{
   public partial class DroppablePage : BasePage
    {

        public DroppablePage(IWebDriver driver)
            : base(driver)
        {
        }

    // internal void AssertDropped1(string v, string text)
    // {
    //     throw new NotImplementedException();
    // }
    }
}
