using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace SynerAutomation
{
    class Program
    {
        private static string last_name;

        public static object Assert { get; private set; }

        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://synergiesservices.hirecentric.com/jobs/100934.html");

           // driver.Navigate().Forward();

            try
            {

                IWebElement firstNameInform = driver.FindElement(By.Id("first_name"));
                firstNameInform.SendKeys("Erick");
                IWebElement lastNameInform = driver.FindElement(By.Id("last_name"));
               lastNameInform.SendKeys("Cruz");
               driver.FindElement(By.Id("middle_name")).SendKeys("EC");
               driver.FindElement(By.Id("email")).SendKeys("junemerassaint@gmail.com");
               driver.FindElement(By.Id("email_confirm")).SendKeys("junemerassaint@gmail.com");
               driver.FindElement(By.Id("contact_number")).SendKeys("809-724-2466");
               driver.FindElement(By.Id("contact_number_type")).SendKeys("Home");
               driver.FindElement(By.Id("street1")).SendKeys("Embrujo 3"); 
               driver.FindElement(By.Name("street2")).SendKeys("Villa Olimpica");
               driver.FindElement(By.Name("country_id")).SendKeys("United States");
               driver.FindElement(By.Name("state_id")).SendKeys("New York");
               driver.FindElement(By.Id("city")).SendKeys("Brooklyn");
               driver.FindElement(By.Id("zip")).SendKeys("51000");//
               driver.FindElement(By.Id("apply_button")).Click();


             Console.WriteLine("Practicing QA Automation ");

            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
  
}
