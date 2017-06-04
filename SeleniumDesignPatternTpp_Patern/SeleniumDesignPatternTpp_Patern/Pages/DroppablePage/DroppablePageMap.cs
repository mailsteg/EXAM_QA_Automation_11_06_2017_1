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
        public IWebElement DropableSource
        {           
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));
            }
         }
        public IWebElement DropableTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }
        public IWebElement DropableButonAccept
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));
            }
        }
        public IWebElement DropableAcceptSource
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableaccept"));
            }
        }
        public IWebElement DropableAcceptTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableaccept"));
            }
        }
        public IWebElement DropableButonPreventPropag
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-3\"]"));
            }
        }
        public IWebElement DropablePreventSource
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableprop"));
            }
        }
        public IWebElement DropablePreventTarget1
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableprop"));
            }
        }
        public IWebElement DropablePreventTarget2
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppable2-inner"));
            }
        }
        public IWebElement DropableButtonRevert
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }
        public IWebElement DropableRevertSource1
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggablerevert"));
            }
        }
        public IWebElement DropableRevertSource2
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggablerevert2"));
            }
        }
        public IWebElement DropableRevertTarget
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppablerevert"));
            }
        }
        public IWebElement DropableButtoncart
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-5"));
            }
        }
        public IWebElement DropableCartsource
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-10"));
            }
        }
        public IWebElement DropableCartTarget
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"cart\"]/div/ol/li"));
            }
        }
    }
}
