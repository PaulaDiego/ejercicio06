using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio06;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Metodo mt = new Metodo();
            mt.Concatenar();

        }
    }
}
