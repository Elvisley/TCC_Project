using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication8.Domain;

namespace TestesUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Register re = new Register();
            re.nomecredor = "ELVISLEY SOUZA";

            string teste = re.retirarCaracteresEspeciais(re.nomecredor);

            Assert.AreEqual("ELVISLEYSOUZA", teste);
        }
    }
}
