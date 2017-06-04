using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumDesignPatternTpp_Patern.Pages.StoarablePage
{
    public static class StoarablePageAsserter
    {

        public static void AssertSortablePingPong1(this StoarablePage page, string text)
        {
            Assert.AreEqual( text, page.SortableItem1.Text);
        }
    }
}
