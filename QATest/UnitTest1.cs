using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
namespace QATest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            IWebDriver driver2 = new ChromeDriver();
            driver2.Url = "http://localhost:54507/Factura/Create";
            IWebElement IdElement = driver2.FindElement(By.Id("IdFactura"));
            IdElement.SendKeys("1");
            IWebElement DescripcionElement = driver2.FindElement(By.Id("Descripcion"));
            DescripcionElement.SendKeys("Compra total");
            IWebElement IvaElement = driver2.FindElement(By.Id("Iva"));
            IvaElement.SendKeys("21%");
            IWebElement PrecioElement = driver2.FindElement(By.Id("Precio"));
            PrecioElement.SendKeys("50");

            PrecioElement.Submit();




        }
    }
}
