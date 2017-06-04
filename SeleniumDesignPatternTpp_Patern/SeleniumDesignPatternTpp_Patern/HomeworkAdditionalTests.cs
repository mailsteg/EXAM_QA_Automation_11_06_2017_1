using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumDesignPatternTpp_Patern.Pages.Home_Page;
using SeleniumDesignPatternTpp_Patern.Pages.ResizablePage;
using SeleniumDesignPatternTpp_Patern.Pages.SelectablePage;
using SeleniumDesignPatternTpp_Patern.Pages.StoarablePage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumDesignPatternTpp_Patern
{
    [TestFixture]
    class HomeworkAdditionalTests
    {
        private IWebDriver driver;
        [SetUp]
        public void InitialRuns()
        {
            this.driver = new ChromeDriver();
            Home_Page HomePage = new Home_Page(this.driver);

            HomePage.Navigate();

        }
        [TearDown]

        public void EndOfAllTests()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                string path = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                File.WriteAllText(path, TestContext.CurrentContext.Test.FullName + "    " + TestContext.CurrentContext.TestDirectory);
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }

            this.driver.Quit();
        }


        [Test, Property("Resizable_01", 2)]
        [Author("Todor Peshin")]
        public void Resizable_01()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_ResizableID.Click();
            ResizablePage resizePage = new ResizablePage(this.driver);
            Actions builder = new Actions(this.driver);
            int a = resizePage.Resizable_Djijavka1.Location.X;
            int b = resizePage.Resizable_Djijavka1.Location.Y;
            var resizeMove = builder.ClickAndHold(resizePage.Resizable_Djijavka1).MoveByOffset(150, 0).Release();
            resizeMove.Perform();
            resizePage.AssertResizePage(a + 133, b);
        }
        [Test, Property("Resizable_02", 2)]
        [Author("Todor Peshin")]
        public void Resizable_02()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_ResizableID.Click();
            ResizablePage resizePage = new ResizablePage(this.driver);
            Actions builder = new Actions(this.driver);
            int a = resizePage.Resizable_Djijavka1.Location.X;
            int b = resizePage.Resizable_Djijavka1.Location.Y;
            var resizeMove = builder.ClickAndHold(resizePage.Resizable_Djijavka1).MoveByOffset(0, 150).Release();
            resizeMove.Perform();
            resizePage.AssertResizePage(a, b + 133);
        }
        [Test, Property("Resizable_03", 2)]
        [Author("Todor Peshin")]
        public void Resizable_03()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_ResizableID.Click();
            ResizablePage resizePage = new ResizablePage(this.driver);
            Actions builder = new Actions(this.driver);
            int a = resizePage.Resizable_Djijavka1.Location.X;
            int b = resizePage.Resizable_Djijavka1.Location.Y;
            var resizeMove = builder.ClickAndHold(resizePage.Resizable_Djijavka1).MoveByOffset(150, 150).Release();
            resizeMove.Perform();
            resizePage.AssertResizePage(a + 133, b + 133);
        }
        [Test, Property("Selectable_01", 2)]
        [Author("Todor Peshin")]
        public void Selectable_01()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_SelectableID.Click();
            SelectablePage selectPage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var select1 = builder.Click(selectPage.SelectableElement1);
            select1.Perform();
            selectPage.AssertSelectPage1("true");
        }
        [Test, Property("Selectable_02", 2)]
        [Author("Todor Peshin")]
        public void Selectable_02()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_SelectableID.Click();
            SelectablePage selectPage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var select1 = builder.KeyDown(Keys.LeftControl).Click(selectPage.SelectableElement1).Click(selectPage.SelectableElement2).KeyUp(Keys.LeftControl);
            select1.Perform();
            selectPage.AssertSelectPage2("true");
        }
        [Test, Property("Selectable_03", 2)]
        [Author("Todor Peshin")]
        public void Selectable_03()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_SelectableID.Click();
            SelectablePage selectPage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var select1 = builder.KeyDown(Keys.LeftControl)
                .Click(selectPage.SelectableElement1)
                .Click(selectPage.SelectableElement2)
                .Click(selectPage.SelectableElement1)
                .KeyUp(Keys.LeftControl);
            select1.Perform();
            selectPage.AssertSelectPage1("false");
        }

        [Test, Property("Sortable1_01", 2)]
        [Author("Todor Peshin")]
        public void Sortable_01()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_StorableID.Click();
            StoarablePage sortPage = new StoarablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var action1 = builder.ClickAndHold(sortPage.SortableItem1).MoveToElement(sortPage.SortableItem3).MoveByOffset(0, 2).Release();
            action1.Perform();
            sortPage.AssertSortablePingPong1("Item 2");
        }
        [Test, Property("Sortable1_02", 2)]
        [Author("Todor Peshin")]
        public void Sortable_02()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_StorableID.Click();
            StoarablePage sortPage = new StoarablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var action1 = builder.ClickAndHold(sortPage.SortableItem1).MoveToElement(sortPage.SortableItem3).Release();
            action1.Perform();
            sortPage.AssertSortablePingPong1("Item 1");
        }
        [Test, Property("Sortable1_03", 2)]
        [Author("Todor Peshin")]
        public void Sortable_03()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_StorableID.Click();
            StoarablePage sortPage = new StoarablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var action1 = builder.ClickAndHold(sortPage.SortableItem3).MoveToElement(sortPage.SortableItem1).MoveByOffset(0, 2).Release();
            action1.Perform();
            sortPage.AssertSortablePingPong1("Item 1");
        }







    }
}
