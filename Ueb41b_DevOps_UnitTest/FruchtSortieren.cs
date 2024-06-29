using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Ueb08d_Sortieren_Fruechte;

namespace Ueb41b_DevOps_UnitTest
{
    [TestClass]
    public class FruchtSortieren
    {
        [TestMethod]
        public void TestMethod1()
        {
            var apfel1 = new Apfel { Preis = 1 };
            Assert.IsTrue(apfel1 != null);
        }

        [TestMethod]
        public void Test_Sortieren()
        {
            List<Frucht> fruechte = new List<Frucht>();

            fruechte.Add(new Birne { Preis = 1.25f });
            fruechte.Add(new Birne { Preis = 0.95f });
            fruechte.Add(new Apfel { Preis = 0.8f });
            fruechte.Add(new Apfel { Preis = 0.9f });
            fruechte.Add(new Birne { Preis = 1.1f });
            fruechte.Add(new Birne { Preis = 1.0f });

            // Sortieren aufsteigend
            fruechte.Sort(new PreisComparer());

            int idx = 0;
            foreach (var f in fruechte)
            {
                if (idx == 0)
                {
                    Assert.IsTrue(f.Preis == 0.8f);
                }

                idx++;
            }
        }
    }
}