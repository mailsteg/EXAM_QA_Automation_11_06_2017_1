using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumDesignPatternTpp_Patern.Pages.ResizablePage
{
  public static  class ResizablePageAsserter
    {

        public static void AssertResizePage(this ResizablePage page, int text, int text1)
        {
            Assert.LessOrEqual(text, page.Resizable_Djijavka1.Location.X);
            Assert.LessOrEqual(text1, page.Resizable_Djijavka1.Location.Y);
        }
    }
}
