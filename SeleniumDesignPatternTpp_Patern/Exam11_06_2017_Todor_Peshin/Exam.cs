using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Exam11_06_2017_Todor_Peshin.Pages.Home_Page;

namespace Exam11_06_2017_Todor_Peshin
{
    public static class Exam
    {
        public static void Main()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Home_Page Home = new Home_Page(driver);
            Home.Navigate();

            


            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"test.jpg", ScreenshotImageFormat.Jpeg);
           // driver.Close();
        }
    }
}
