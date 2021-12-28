using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForestaSK.UnitTesty
{
    [TestClass]
    public class Gulatina
    {
        [TestMethod]
        public void PerformanceTest()
        {
            double result = default;
            int cnt = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.BK, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.BO, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.BP, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.DB, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.JD, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.SC, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.SM, i / 10.0M, j + 1);
                    result += Kubikovanie.Gulatina.Objem(Kubikovanie.Gulatina.Drevina.TK, i / 10.0M, j + 1);
                    cnt += 8;
                }
            }
            Assert.IsTrue(cnt == 800000);
        }
        [TestMethod]
        public void TestBK_24_1()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 1, 24, 0.0415, 0.0002);
        }
        [TestMethod]
        public void TestBK_25_1()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 1, 25, 0.0452, 0.0001);
        }
        [TestMethod]
        public void TestBK_26_1()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 1, 26, 0.0491, 0.0002);
        }
        [TestMethod]
        public void TestBK_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 4, 24, 0.166, 0.0005);
        }
        [TestMethod]
        public void TestBK_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 4, 25, 0.181, 0.0002);
        }
        [TestMethod]
        public void TestBK_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 4, 26, 0.196, 0.0002);
        }
        [TestMethod]
        public void TestBK_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 6, 100, 4.48, 0.003);
        }
        [TestMethod]
        public void TestBK_129_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 6, 129, 7.46, 0.003);
        }
        [TestMethod]
        public void TestBK_130_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 6, 130, 7.58, 0.001);
        }
        [TestMethod]
        public void TestBK_160_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 6, 160, 11.50, 0.01);
        }
        [TestMethod]
        public void TestBK_Minus16_6()
        {
            AssertOutOfRange(Kubikovanie.Gulatina.Drevina.BK, 6, -16);
        }
        [TestMethod]
        public void TestBK_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BK, 6, 258, 30, 0.1);
        }
        [TestMethod]
        public void TestBO_14_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BO, 4, 14, 0.0573, 0.000001);
        }
        [TestMethod]
        public void TestBO_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BO, 4, 25, 0.184, 0.00025);
        }
        [TestMethod]
        public void TestBO_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BO, 4, 26, 0.2, 0.001);
        }
        [TestMethod]
        public void TestBO_60_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BO, 6, 60, 1.52, 0.012);
        }
        [TestMethod]
        public void TestBO_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BO, 6, 258, 28.24, 0.01);
        }
        [TestMethod]
        public void TestBP_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BP, 4, 25, 0.158);
        }
        [TestMethod]
        public void TestBP_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BP, 4, 24, 0.144);
        }
        [TestMethod]
        public void TestBP_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BP, 4, 26, 0.171);
        }
        [TestMethod]
        public void TestBP_100_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BP, 4, 100, 2.61, 0.003);
        }
        [TestMethod]
        public void TestBP_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.BP, 6, 258, 26.34, 0.01);
        }
        [TestMethod]
        public void TestDB_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.DB, 4, 24, 0.144, 0.001);
        }
        [TestMethod]
        public void TestDB_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.DB, 4, 25, 0.158, 0.001);
        }
        [TestMethod]
        public void TestDB_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.DB, 4, 26, 0.171, 0.001);
        }
        [TestMethod]
        public void TestDB_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.DB, 6, 100, 4.08, 0.003);
        }
        [TestMethod]
        public void TestDB_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.DB, 6, 258, 27.78, 0.01);
        }
        [TestMethod]
        public void TestJD_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.JD, 4, 24, 0.165, 0.001);
        }
        [TestMethod]
        public void TestJD_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.JD, 4, 25, 0.180, 0.002);
        }
        [TestMethod]
        public void TestJD_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.JD, 4, 26, 0.195, 0.003);
        }
        [TestMethod]
        public void TestJD_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.JD, 6, 100, 4.28, 0.01);
        }
        [TestMethod]
        public void TestJD_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.JD, 6, 258, 28.83, 0.01);
        }
        [TestMethod]
        public void TestSC_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SC, 4, 24, 0.15, 0.006);
        }
        [TestMethod]
        public void TestSC_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SC, 4, 25, 0.16, 0.005);
        }
        [TestMethod]
        public void TestSC_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SC, 4, 26, 0.17, 0.003);
        }
        [TestMethod]
        public void TestSC_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SC, 6, 100, 3.62, 0.003);
        }
        [TestMethod]
        public void TestSC_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SC, 6, 258, 24.13, 0.01);
        }
        [TestMethod]
        public void TestSM_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SM, 4, 24, 0.165, 0.0004);
        }
        [TestMethod]
        public void TestSM_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SM, 4, 25, 0.180, 0.0006);
        }
        [TestMethod]
        public void TestSM_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SM, 4, 26, 0.195, 0.00061);
        }
        [TestMethod]
        public void TestSM_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SM, 6, 100, 4.37, 0.002);
        }
        [TestMethod]
        public void TestSM_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.SM, 6, 258, 29.35, 0.01);
        }
        [TestMethod]
        public void TestTK_24_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.TK, 4, 24, 0.15, 0.006);
        }
        [TestMethod]
        public void TestTK_25_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.TK, 4, 25, 0.17, 0.005);
        }
        [TestMethod]
        public void TestTK_26_4()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.TK, 4, 26, 0.18, 0.003);
        }
        [TestMethod]
        public void TestTK_100_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.TK, 6, 100, 4.05, 0.01);
        }
        [TestMethod]
        public void TestTK_258_6()
        {
            AssertDiff(Kubikovanie.Gulatina.Drevina.TK, 6, 258, 26.85, 0.01);
        }
        #region helper methods
        static void AssertDiff(Kubikovanie.Gulatina.Drevina dr, decimal dlzka, int priemer, double expected, double diffThreshold = 0.01)
        {
            var result = Kubikovanie.Gulatina.Objem(dr, dlzka, priemer);
            var diff = System.Math.Abs(result - expected);
            Assert.IsTrue(diff < diffThreshold);
        }

        static void AssertOutOfRange(Kubikovanie.Gulatina.Drevina dr, decimal dlzka, int priemer)
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Kubikovanie.Gulatina.Objem(dr, dlzka, priemer));
        }
        #endregion
    }
}
