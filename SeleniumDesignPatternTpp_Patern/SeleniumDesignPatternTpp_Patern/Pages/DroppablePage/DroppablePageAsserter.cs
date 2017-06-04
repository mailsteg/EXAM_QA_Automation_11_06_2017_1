using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumDesignPatternTpp_Patern.Pages.DroppablePage
{
   public static class DroppablePageAsserter
    {


        public static void AssertDropped1(this DroppablePage page, string text)
        {
            Assert.AreEqual(text,page.DropableTarget.Text);           
        }
        public static void AssertDroppedAccept(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.DropableAcceptTarget.Text);
        }
        public static void AssertDroppedPrevent(this DroppablePage page, string text)
        {
           // Assert.AreEqual(text, page.DropablePreventTarget1.Text);
            Assert.AreEqual(text, page.DropablePreventTarget2.Text);
        }
        public static void AssertDroppedRevertt(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.DropableRevertTarget.Text);
        }
        public static void AssertDroppedCart(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.DropableCartTarget.Text);
        }
    }
}
