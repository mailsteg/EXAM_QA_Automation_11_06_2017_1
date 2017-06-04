using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternTpp_Patern.Pages.Home_Page
{
    public partial class Home_Page : BasePage
    {

        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.TagName("title"));
            }
        }

        public IWebElement Button_DraggableID
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-140")));
                return this.Driver.FindElement(By.Id("menu-item-140"));
            }
        }
        public IWebElement Button_DroppableID
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-141")));
                return this.Driver.FindElement(By.Id("menu-item-141"));
            }
        }
        public IWebElement Button_ResizableID
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-143")));
                return this.Driver.FindElement(By.Id("menu-item-143"));
            }
        }
        public IWebElement Button_SelectableID
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-142")));
                return this.Driver.FindElement(By.Id("menu-item-142"));
            }
        }
        public IWebElement Button_StorableID
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("menu-item-151")));
                return this.Driver.FindElement(By.Id("menu-item-151"));
            }
        }
       
        public IWebElement Logo
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"site_navigation\"]/div/div[1]/a/img")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"site_navigation\"]/div/div[1]/a/img"));
            }
        }

    }
}
