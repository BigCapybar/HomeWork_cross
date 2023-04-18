using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//для работы с атрибутами TestClass/TestMethod

namespace MyCalculatorLibTests
{
    [TestClass]
    public class MyCalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30return() //это и есть сам unit - тест
        {
            //arrange - настройка
        }
    }
}
