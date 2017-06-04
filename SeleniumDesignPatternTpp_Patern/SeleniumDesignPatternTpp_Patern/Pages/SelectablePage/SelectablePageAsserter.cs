using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumDesignPatternTpp_Patern.Pages.SelectablePage
{
   public static class SelectablePageAsserter
    {

        public static void AssertSelectPage1(this SelectablePage page, string text)
        {
            Assert.IsTrue(page.SelectableElement1.Enabled);
        }
        public static void AssertSelectPage2(this SelectablePage page, string text)
        {
            Assert.IsTrue(page.SelectableElement1.Enabled);
            Assert.IsTrue(page.SelectableElement2.Enabled);
        }
    }
}
