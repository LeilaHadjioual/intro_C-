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
        //  [TestMethod()]
        //  public void MessageTest()
        //  {
        //      Assert.Fail();
        //  }

        //----------------------------- TESTS SANS UTILISATION DE L'INTERFACE ----------------------------------------------
        //------méthode sans argument dans la méthode getHelloMessage---------
        //  [TestMethod()]
        //  public void GetHelloMessageTest_bonjour()
        //  {
        //      Message testMsg = new Message(9, 13, 18);
        //      String resultTest = testMsg.GetHelloMessage();
        //      Assert.IsTrue(resultTest.Contains("Bonjour"));
        //      ou Assert.AreEqual("Bonjour leila.hadjioual mardi 21 aout etc...", resultTest); //noter mot à mot l'affichage sinon ne fonctionne pas
        //  }

        //-------méthodes avec argument dans getHelloMessage------------------
        //      [TestMethod()]
        //      public void GetHelloMessageTest_bonjour()
        //      {
        //          Message testMsg = new Message(9, 13, 18);
        //          DateTime date = new DateTime(2018, 08, 22, 10, 00, 00);
        //          String resultTest = testMsg.GetHelloMessage(date);
        //          Assert.IsTrue(resultTest.Contains("Bonjour"));
        //      }
        //      
        //      [TestMethod()]
        //      public void GetHelloMessageTest_bonsoir()
        //      {
        //          Message testMsg = new Message(9, 13, 18);
        //          DateTime date = new DateTime(2018, 08, 22, 22, 00, 00);
        //          String resultTest = testMsg.GetHelloMessage(date);
        //          Assert.IsTrue(resultTest.Contains("Bonsoir"));
        //      }
     
        //      [TestMethod()]
        //      public void GetHelloMessageTest_bonWeekend()
        //      {       
        //          Message testMsg = new Message(9, 13, 18);
        //          DateTime date = new DateTime(2018, 08, 25, 22, 00, 00);
        //          String resultTest = testMsg.GetHelloMessage(date);
        //          Assert.IsTrue(resultTest.Contains("Bon weekend"));
        //      }

        //      [TestMethod()]
        //      public void GetHelloMessageTest_bonApresMidi()
        //      {     
        //          Message testMsg = new Message(9, 13, 18);
        //          DateTime date = new DateTime(2018, 08, 21, 16, 00, 00);
        //          String resultTest = testMsg.GetHelloMessage(date);
        //          Assert.IsTrue(resultTest.Contains("Bon après-midi"));
        //      }

        //------------------------- TESTS AVEC UTILISATION DE L'INTERFACE  ---------------------------------------------------------------       
        [TestMethod()]
        public void GetHelloMessageTest_bonjour()
        {
            DateTime date = new DateTime(2018, 08, 22, 10, 00, 00);
            Message testMsg = new Message(new FakeDateTime(date));
            String resultTest = testMsg.GetHelloMessage();
            Assert.IsTrue(resultTest.Contains("Bonjour"));
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonsoirr()
        {
            DateTime date = new DateTime(2018, 08, 23, 22, 00, 00);
            Message testMsg = new Message(new FakeDateTime(date));
            String resultTest = testMsg.GetHelloMessage();
            Assert.IsTrue(resultTest.Contains("Bonsoir"));
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonWeekend()
        {
            DateTime date = new DateTime(2018, 08, 25, 10, 00, 00);
            Message testMsg = new Message(new FakeDateTime(date));
            String resultTest = testMsg.GetHelloMessage();
            Assert.IsTrue(resultTest.Contains("Bon weekend"));
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonApresMidi()
        {
            DateTime date = new DateTime(2018, 08, 23, 17, 30, 00);
            Message testMsg = new Message(new FakeDateTime(date));
            String resultTest = testMsg.GetHelloMessage();
            Assert.IsTrue(resultTest.Contains("Bon après-midi"));
        }
    }
}