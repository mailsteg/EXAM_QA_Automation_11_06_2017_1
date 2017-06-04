using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternTpp_Patern.Pages.RegistartionPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertRegPageISLoaded(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SubmitButton.Displayed);
        }

        public static void AssesrtSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }

        public static void AssertErrorMessageFirstNamereqNegativ(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames_fieldReq.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames_fieldReq.Text);
        }
        //Notify
        public static void AssertErrorMessageFirstNamereqPositive(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames_fieldReq.Displayed);      
        }
        public static void AssertErrorMessageSecondNamereqNegativ(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames_fieldReq.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames_fieldReq.Text);
        }

        public static void AssertErrorMessageSecondNamereqPositive(this RegistrationPage page, string text)
        {
            Assert.False(page.ErrorMessagesForNames_fieldReq.Displayed);
        }

        public static void AssertErrorMessageHoobyReqNegative(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesHobbyReq.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesHobbyReq.Text);
        }
        public static void AssertErrorMessageHoobyReqPositive(this RegistrationPage page, string text)
        {
            Assert.False(page.ErrorMessagesHobbyReq.Displayed);
        }

        public static void AssertErrorMessagePhoneReq(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesForPhone.Text);
        }
        public static void AssertErrorMessagePhone10Digits(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesForPhone.Text);
        }
        public static void AssertErrorMessageUserNameReq(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesUserNameFieldReq.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesUserNameFieldReq.Text);
        }
        public static void AssertErrorMessageEmailReq(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesEmailFieldReq.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesEmailFieldReq.Text);
        }
        public static void AssertErrorMessagePasswordReq(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesPasswordReq.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesPasswordReq.Text);
        }
        public static void AssertErrorMessageConfirmPasswordReq(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesConfirmPasswordReq.Displayed);
            Assert.AreEqual(text, page.ErrorMessagesConfirmPasswordReq.Text);
        }
        public static void AssertEndOfThisWeek(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.LogoGator.Displayed);
            Assert.AreEqual(text, page.LogoGator.Text);
        }

        public static void AssertStrenfght(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.Strength_Indicator.Displayed);
            StringAssert.Contains(text, page.Strength_Indicator.Text);
        }
    }
}
