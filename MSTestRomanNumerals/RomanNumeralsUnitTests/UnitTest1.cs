using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Program romanConverter;
        [TestInitialize]
        public void Setup()
        {
            romanConverter = new Program();
        }

        [TestMethod]
        public void TestRomanNumeral_I_1()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("I");
            Assert.AreEqual(val, 1);
        }

        [TestMethod]
        public void TestRomanNumeral_II_2()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("II");
            Assert.AreEqual(val, 2);
        }

        [TestMethod]
        public void TestRomanNumeral_IV_4()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("IV");
            Assert.AreEqual(val, 4);
        }

        [TestMethod]
        public void TestRomanNumeral_V_5()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("V");
            Assert.AreEqual(val, 5);
        }

        [TestMethod]
        public void TestRomanNumeral_VII_7()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("VII");
            Assert.AreEqual(val, 7);
        }

        [TestMethod]
        public void TestRomanNumeral_IX_9()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("IX");
            Assert.AreEqual(val, 9);
        }

        [TestMethod]
        public void TestRomanNumeral_X_10()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("X");
            Assert.AreEqual(val, 10);
        }

        [TestMethod]
        public void TestRomanNumeral_XIII_13()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("XIII");
            Assert.AreEqual(val, 13);
        }

        [TestMethod]
        public void TestRomanNumeral_XV_15()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("XV");
            Assert.AreEqual(val, 15);
        }

        [TestMethod]
        public void TestRomanNumeral_XVII_17()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("XVII");
            Assert.AreEqual(val, 17);
        }

        [TestMethod]
        public void TestRomanNumeral_XX_20()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("XX");
            Assert.AreEqual(val, 20);
        }


        [TestMethod]
        public void TestRomanNumeral_L_50()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("L");
            Assert.AreEqual(val, 50);
        }

        [TestMethod]
        public void TestRomanNumeral_LV_55()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("LV");
            Assert.AreEqual(val, 55);
        }

        [TestMethod]
        public void TestRomanNumeral_C_100()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("C");
            Assert.AreEqual(val, 100);
        }

        [TestMethod]
        public void TestRomanNumeral_D_500()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("D");
            Assert.AreEqual(val, 500);
        }

        [TestMethod]
        public void TestRomanNumeral_M_1000()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("M");
            Assert.AreEqual(val, 1000);
        }

        [TestMethod]
        public void TestRomanNumeral_XLIX_47()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("XLIX");
            Assert.AreEqual(val, 49);
        }

        [TestMethod]
        public void TestRomanNumeral_DCCC_800()
        {
            int val = romanConverter.ConvertRomanNumeralToArabic("DCCC");
            Assert.AreEqual(val, 800);
        }
    }
}
