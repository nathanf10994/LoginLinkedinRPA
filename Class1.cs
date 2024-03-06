using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLinkedinRPA
{
    public class Class1
    {
        public IEnumerable <string> Parametros { get; private set; }
        public string Url { get; private set; }
        public ChromeDriver driver { get; private set; }

        public Class1(string user, string password)
        {
            Parametros = new List<string> { user, password };
            Url = "https://www.linkedin.com/home";
            driver = new ChromeDriver();
        }
        public void Executar()
        {
            driver.Navigate().GoToUrl(Url);
            driver.FindElement(By.XPath("//*[@id=\'session_key\']")).SendKeys(Parametros.ElementAtOrDefault(0));
            driver.FindElement(By.XPath("//*[@id=\'session_password\']")).SendKeys(Parametros.ElementAtOrDefault(1));
            driver.FindElement(By.XPath("//*[@id=\"main-content\"]/section[1]/div/div/form/div[2]/button")).Click();

        }
    }
}
