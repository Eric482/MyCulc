using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class ResultTests
    {
        [TestMethod()]
        public void ResultOfOperTestSumm()
        {
            int n = 5;
            string t = "6";
            string o = "+";
            int expected = 11;
            Result result = new Result();
            double actual = result.ResultOfOper(o,n,t);
            Assert.AreEqual(expected, actual);
        } 
        [TestMethod()]
        public void ResultOfOperTestDiff()
        {
            int n = 55;
            string t = "60";
            string o = "-";
            int expected = -5;
            Result result = new Result();
            double actual = result.ResultOfOper(o, n, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ResultOfOperTestMult()
        {
            int n = 2;
            string t = "-10";
            string o = "*";
            int expected = -20;
            Result result = new Result();
            double actual = result.ResultOfOper(o, n, t);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ResultOfOperTestDiv()
        {
            int n = 10;
            string t = "2";
            string o = "/";
            int expected = 5;
            Result result = new Result();
            double actual = result.ResultOfOper(o, n, t);
            Assert.AreEqual(expected, actual);
        }
       
    }
}