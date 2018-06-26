using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class TranslatorTest
  {
    [TestMethod]
    public void IsTranslator_NumberDivisibleByFour_True()
    {
      Assert.AreEqual(false, Translator.returnTest(1,3));
    }
  }
}
