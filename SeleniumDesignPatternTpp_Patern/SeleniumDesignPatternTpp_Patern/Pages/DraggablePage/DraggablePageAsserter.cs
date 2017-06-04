using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SeleniumDesignPatternTpp_Patern.Pages.DraggablePage
{
    public static class DraggablePageAsserter
    {

        public static void AssertDraggablePage(this DraggablePage page, int text, int text1)
        {
            Assert.IsTrue(page.DraggMeElement.Location.X == text);
            Assert.IsTrue(page.DraggMeElement.Location.Y == text1);
        }
        public static void AssertDraggMoveVertical(this DraggablePage page, int text)
        {
            Assert.AreEqual(text,page.DraggableConstrainVertical.Location.X);         
        }
        public static void AssertDraggHorisontal(this DraggablePage page, int text)
        {
            Assert.AreEqual(text, page.DraggableConstrainVertical.Location.Y);
        }
        public static void AssertDraggContaindWithBoxHorisontal(this DraggablePage page, int text)
        {
            Assert.LessOrEqual(text, page.DraggableConstrainBOX.Location.X);
        }
        public static void AssertDraggContaindWithBoxVertical(this DraggablePage page, int text)
        {
            Assert.LessOrEqual(text, page.DraggableConstrainBOX.Location.Y);
        }
    }
}
