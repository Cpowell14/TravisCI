using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        //Addition tests

        [Test]
        public void Add_ValidPowell()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidPowell()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullPowell()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        //Subtraction tests

        [Test]
        public void Subtract_ValidPowell()
        {
            Assert.AreEqual(10, Program.Subtract("20", "3"));
            Assert.AreEqual(3, Program.Subtract("5", "2"));
            Assert.AreEqual(8, Program.Subtract("15", "7"));
        }

        [Test]
        public void Subtract_InvalidPowell()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullPowell()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        //Multiplication tests

        [Test]
        public void Multiply_ValidPowell()
        {
            Assert.AreEqual(2, Program.Multiply("1", "5"));
            Assert.AreEqual(100, Program.Multiply("4", "25"));
            Assert.AreEqual(60, Program.Multiply("3", "20"));
        }

        [Test]
        public void Multiply_InvalidPowell()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullPowell()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        //Division Tests

        [Test]
        public void Divide_ValidPowell()
        {
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(12, Program.Divide("84", "7"));
        }

        [Test]
        public void Divide_InvalidPowell()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullPowell()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        //Power Tests

        [Test]
        public void Power_ValidPowell()
        {
            Assert.AreEqual(1, Program.Power("10", "0"));
            Assert.AreEqual(15, Program.Power("15", "1"));
            Assert.AreEqual(25, Program.Power("5", "2"));
        }

        [Test]
        public void Power_InvalidPowell()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullPowell()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }

    }
}
