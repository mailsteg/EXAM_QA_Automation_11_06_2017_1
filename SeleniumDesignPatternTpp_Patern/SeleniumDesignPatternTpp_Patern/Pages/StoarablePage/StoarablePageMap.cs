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
  public partial  class StoarablePage : BasePage
    {


           public IWebElement SortableItem1
           {
               get
               {
                   return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[1]"));
               }
           }
            public IWebElement SortableItem2
            {
                get
                {
                    return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[2]"));
                }
            }
            public IWebElement SortableItem3
            {
                get
                {
                    return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[3]"));
            }         
        }

        public IWebElement SortableTable
        {
            get
            {
                return this.Driver.FindElement(By.Id("sortable"));
            }
        }

    }
}
