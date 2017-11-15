using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCodeLibrary;
using System.Collections.Generic;

namespace MorseCodeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMorseDecode()
        {
            string textToDecode = "- . ... - .----    - . ... - ..---    - . ... - ...--";
            string solution = "TEST1 TEST2 TEST3";
            Morse morse = new Morse();
            string result = morse.DecodeMessage(textToDecode);
            Assert.IsTrue(result == solution);
        }

        [TestMethod]
        public void TestMorseDecodeThreeSpaces()
        {
            string textToDecode = "- . ... - .----   - . ... - ..---    - . ... - ...--";
            string solution = "TEST1 TEST2 TEST3";
            Morse morse = new Morse();
            string result = morse.DecodeMessage(textToDecode);
            Assert.IsFalse(result == solution);
        }

        [TestMethod]
        public void TestMorseDecodeWrongChar()
        {
            string textToDecode = "- . .-. - .----    - . ... - ..---    - . ... - ...--";
            string solution = "TEST1 TEST2 TEST3";
            Morse morse = new Morse();
            string result = morse.DecodeMessage(textToDecode);
            Assert.IsFalse(result == solution);
        }

        [TestMethod]
        public void TestMorseDecodeLetters()
        {
            string textToDecode = "TEST1 TEST2 TEST3";
            string solution = "TEST1 TEST2 TEST3";
            Morse morse = new Morse();
            string result = morse.DecodeMessage(textToDecode);
            Assert.IsFalse(result == solution);
        }

        [TestMethod]
        public void IsExceptionHandled()
        {
            Morse morse = new Morse();
            try
            {
                morse.DecodeMessage(".....");
            }
            catch(KeyNotFoundException)
            {
                Assert.Fail();
            }
        }
    }
}
