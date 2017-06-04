using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumDesignPatternTpp_Patern.Models;
using SeleniumDesignPatternTpp_Patern.Pages.Home_Page;
using SeleniumDesignPatternTpp_Patern.Pages.RegistartionPage;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Interactions;
using SeleniumDesignPatternTpp_Patern.Pages.DroppablePage;
using SeleniumDesignPatternTpp_Patern.Pages.DraggablePage;
using SeleniumDesignPatternTpp_Patern.Pages.ResizablePage;

namespace SeleniumDesignPatternTpp_Patern
{
    [TestFixture]
    class SeleniumWDAdvancedHomework
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
               this.driver.Quit();
           }



        [Test, Property("Draggable01", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDraggable_00()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DraggableID.Click();
            DraggablePage draggPage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);           
            var simpleMove = builder.ClickAndHold(draggPage.DraggMeElement).MoveByOffset(200, 200).Release();
            simpleMove.Perform();
            draggPage.AssertDraggablePage(draggPage.DraggMeElement.Location.X + 200, draggPage.DraggMeElement.Location.Y + 200);
           
           
        }
        [Test, Property("Draggable02", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDraggable_01()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DraggableID.Click();
            DraggablePage draggPage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggPage.DraggableConstrainButton.Click();
            var actionVerticalMove = builder.ClickAndHold(draggPage.DraggableConstrainVertical).MoveByOffset(20, 20).Release();
            actionVerticalMove.Perform();
            draggPage.AssertDraggMoveVertical(draggPage.DraggableConstrainVertical.Location.X);


        }
        [Test, Property("Draggable03", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDraggable_02()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DraggableID.Click();
            DraggablePage draggPage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggPage.DraggableConstrainButton.Click();
            var actionVerticalMove = builder.ClickAndHold(draggPage.DraggableConstrainHorisontal).MoveByOffset(20, 20).Release();
            actionVerticalMove.Perform();
            draggPage.AssertDraggHorisontal(draggPage.DraggableConstrainHorisontal.Location.Y);


        }
        [Test, Property("Draggable04", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDraggable_03()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DraggableID.Click();
            DraggablePage draggPage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggPage.DraggableConstrainButton.Click();
            var actionVerticalMove = builder.ClickAndHold(draggPage.DraggableConstrainContainWithBox).MoveByOffset(700, 700).Release();
            actionVerticalMove.Perform();
            draggPage.AssertDraggContaindWithBoxHorisontal(draggPage.DraggableConstrainBOX.Location.X);


        }
        [Test, Property("Draggable05", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDraggable_04()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DraggableID.Click();
            DraggablePage draggPage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggPage.DraggableConstrainButton.Click();
            var actionVerticalMove = builder.ClickAndHold(draggPage.DraggableConstrainContainWithBox).MoveByOffset(700, 700).Release();
            actionVerticalMove.Perform();
            draggPage.AssertDraggContaindWithBoxVertical(draggPage.DraggableConstrainBOX.Location.Y);
        }



        [Test, Property("Dropable01", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDropable_00()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DroppableID.Click();
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            var firstMove = builder.DragAndDrop(droppablePage.DropableSource, droppablePage.DropableTarget);
            firstMove.Perform();

            droppablePage.AssertDropped1("Dropped!");


        }
        [Test, Property("Dropable02", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDropable_01()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DroppableID.Click();
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.DropableButonAccept.Click();
            var move = builder.DragAndDrop(droppablePage.DropableAcceptSource, droppablePage.DropableAcceptTarget);
            move.Perform();
            droppablePage.AssertDroppedAccept("Dropped!");

        }
        [Test, Property("Dropable03", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDropable_02()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DroppableID.Click();
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.DropableButonPreventPropag.Click();
            var move1 = builder.DragAndDrop(droppablePage.DropablePreventSource, droppablePage.DropablePreventTarget1);
            var move2 = builder.DragAndDrop(droppablePage.DropablePreventSource, droppablePage.DropablePreventTarget2);
            move1.Perform();
            move2.Perform();
            droppablePage.AssertDroppedPrevent("Dropped!");

        }
        [Test, Property("Dropable04", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDropable_03()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DroppableID.Click();
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.DropableButtonRevert.Click();
            var move1 = builder.DragAndDrop(droppablePage.DropableRevertSource1, droppablePage.DropableRevertTarget);
            move1.Perform();
            droppablePage.AssertDroppedRevertt("Dropped!");

        }
        [Test, Property("Dropable05", 2)]
        [Author("Todor Peshin")]
        public void NavigatetoDDropable_04()
        {
            Home_Page HOME = new Home_Page(this.driver);
            HOME.Button_DroppableID.Click();
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.DropableButtoncart.Click();
            var uslessmove = builder.DragAndDrop(droppablePage.DropableCartsource, HOME.Button_DroppableID);
            uslessmove.Perform();
            droppablePage.AssertDroppedCart("Add your items here");
        }


   //       [Test, Property("Resizable_01", 2)]
   //       [Author("Todor Peshin")]
   //       public void Resizable_01()
   //       {
   //           Home_Page HOME = new Home_Page(this.driver);
   //           HOME.Button_ResizableID.Click();
       //  ResizablePage resizePage = new ResizablePage(this.driver);
       //  Actions builder = new Actions(this.driver);
       //  var resizeMove = builder.ClickAndHold(resizePage.Resizable_Djijavka1).MoveByOffset(50, 0).Release();
       //  resizeMove.Perform();
       //
       //  resizePage.AssertResizePage(resizePage.Resizable_Djijavka1.Location.X + 50, resizePage.Resizable_Djijavka1.Location.X + 0);

      //  }
    }
}
