using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        //[TestMethod()]
        //public void MessageTest()
        //{
        // Assert.Fail();
        //}

        [TestMethod()]
        public void GetHelloMessageTest_bonjour()
        {
   //------méthode sans argument dans la méthode getHelloMessage---------
            //Message testMsg = new Message(9, 13, 18);
            //String resultTest = testMsg.GetHelloMessage();
            //Assert.IsTrue(resultTest.Contains("Bonjour"));

   //-------méthode avec argument dans getHelloMessage------------------
            Message testMsg = new Message(9, 13, 18);
            DateTime date = new DateTime(2018, 08, 22, 10, 00, 00);
            String resultTest = testMsg.GetHelloMessage(date);
            Assert.IsTrue(resultTest.Contains("Bonjour"));
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonsoir()
        {
  //-------méthode avec argument dans getHelloMessage-------------------
            Message testMsg = new Message(9, 13, 18);
            DateTime date = new DateTime(2018, 08, 22, 22, 00, 00);
            String resultTest = testMsg.GetHelloMessage(date);
            Assert.IsTrue(resultTest.Contains("Bonsoir"));
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonWeekend()
        {
            //-------méthode avec argument dans getHelloMessage-------------------
            Message testMsg = new Message(9, 13, 18);
            DateTime date = new DateTime(2018, 08, 25, 22, 00, 00);
            String resultTest = testMsg.GetHelloMessage(date);
            Assert.IsTrue(resultTest.Contains("Bon weekend"));
        }


        [TestMethod()]
        public void GetHelloMessageTest_bonApresMidi()
        {
            //-------méthode avec argument dans getHelloMessage-------------------
            Message testMsg = new Message(9, 13, 18);
            DateTime date = new DateTime(2018, 08, 21, 16, 00, 00);
            String resultTest = testMsg.GetHelloMessage(date);
            Assert.IsTrue(resultTest.Contains("Bon après-midi"));
        }
    }


}