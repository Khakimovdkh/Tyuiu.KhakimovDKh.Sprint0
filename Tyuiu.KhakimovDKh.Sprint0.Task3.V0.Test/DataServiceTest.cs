﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhakimovDKh.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KhakimovDKh.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(14, DataService.Sum(7, 7));

        }
    }
}