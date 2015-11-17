using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maatwerk_Toets;
using System.Collections.Generic;

namespace Unit_Test_1
{
    [TestClass]
    public class IInkomstenTest
    {
        [TestInitialize]
        public void myTestData()
        {
            // een lijst met IInkomsten om dan te sorteren.
        }

        [TestMethod]
        public void Twee_Verhuringen_Vergelijken()
        {
            DateTime datum = DateTime.Now;
            Feestzaal a = new Feestzaal(datum, 2);            
            Feestzaal b = new Feestzaal(datum, 2);

            Assert.AreEqual(a, b);


            Sportzaal c = new Sportzaal(datum, 1);

            Assert.AreNotEqual(a, c);


            Vergaderruimte d = new Vergaderruimte(datum, 2);

            Assert.AreNotEqual(c, d);
            Assert.AreNotEqual(a, d);
        }

        [TestMethod]
        public void Twee_Lijsten_Van_Verhuringen_Vergelijken()
        {
            DateTime datum = DateTime.Now;

            List<Verhuur> verhuringenA = new List<Verhuur>();
            Feestzaal a = new Feestzaal(datum, 2);
            Vergaderruimte b = new Vergaderruimte(datum, 2);
            verhuringenA.Add(a);
            verhuringenA.Add(b);

            List<Verhuur> verhuringenB = new List<Verhuur>();
            verhuringenA.Add(a);
            verhuringenA.Add(b);

            CollectionAssert.Equals(verhuringenA, verhuringenB);


            List<Verhuur> verhuringenC = new List<Verhuur>();
            Sportzaal c = new Sportzaal(datum, 2);
            verhuringenA.Add(a);
            verhuringenA.Add(c);

            CollectionAssert.AreNotEqual(verhuringenA, verhuringenC);
        }
    }
}
