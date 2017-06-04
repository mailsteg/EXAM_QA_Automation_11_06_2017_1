using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternTpp_Patern.Pages.DraggablePage
{
   public partial class DraggablePage : BasePage
    {
        public IWebElement DraggMeElement
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));
            }
        }
        public IWebElement DraggableConstrainButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement DraggableConstrainVertical
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggabl"));
            }
        }
        public IWebElement DraggableConstrainHorisontal
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggabl2"));
            }
        }
        public IWebElement DraggableConstrainContainWithBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggabl3"));
            }
        }
        public IWebElement DraggableConstrainBOX
        {
            get
            {
                return this.Driver.FindElement(By.Id("containment-wrapper"));
            }
        }

    }
}
