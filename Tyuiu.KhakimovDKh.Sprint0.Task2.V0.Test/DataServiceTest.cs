using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhakimovDKh.Sprint0.Task2.V1.Lib;

namespace Tyuiu.KhakimovDKh.Sprint0.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Doston";
            var res=DataService.GetMessage(name); 
            Assert.AreEqual("Приветь..., Doston", res);
        }
    }
}
