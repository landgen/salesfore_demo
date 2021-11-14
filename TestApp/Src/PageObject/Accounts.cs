﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestApp.Src.PageObject;

namespace TestApp.PageObjects
{
    class Accounts
    {
        IWebDriver driver;
        public Accounts(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        private IWebElement new_button => driver.FindElement(By.XPath("//a[@title='New']"));
        private IWebElement account_menu => driver.FindElement(By.XPath("//a[@title='Accounts']/parent::*"));
        private IWebElement edit_button => driver.FindElement(By.XPath("//div[@class='windowViewMode-normal oneContent active lafPageHost']//div[@class='slds-col slds-size_1-of-1 row region-header']//li[2]"));
        public IWebElement GetAccountMenu()
        {

            return account_menu;

        }
        public IWebElement GetNewButton()
        {

            return new_button;
        }
        public IWebElement GetEditButton()
        {

            return edit_button;
        }
        public IWebElement GetAccountNameFromList(string name)
        {

            return driver.FindElement(By.XPath(string.Format("//a[@title='{0}']", name)));
        }
        public AccountForm OpenForm()
        {
        new_button.Click();
            
            return new AccountForm(driver);
        }
        public AccountForm EditForm()
        {
            edit_button.Click();

            return new AccountForm(driver);
        }

    }
}
