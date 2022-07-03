using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tubes_KPL;

// Faza

namespace UnitTestAutomata
{
    [TestClass]
    public class UnitTestAutomata1
    {
        private const string Expected = "Transisi Berhasil";
        [TestMethod]
        public void TestTransisiAutomata()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Automata.State posisi = Automata.State.TEST, nextPosisi;
                nextPosisi = Automata.State.LOGIN;
                Automata.setPosisi(posisi, nextPosisi);
                Automata.posisiTransition(nextPosisi);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
