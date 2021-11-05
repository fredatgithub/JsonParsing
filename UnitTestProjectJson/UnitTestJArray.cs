using ClassLibraryJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace UnitTestProjectJson
{
  [TestClass]
  public class UnitTestJArray
  {
    [TestMethod]
    public void TestMethod_firstArray()
    {
      string source = "test";
      string expected = "loginId";
      string expected2 = "testuser1";
      string expected3 = "userCase";
      string expected4 = "verify for user";
      JToken result = HelperClass.FetchOneDatum(source);
      Assert.IsTrue(result.ToString().Contains(expected));
      Assert.IsTrue(result.ToString().Contains(expected2));
      Assert.IsTrue(result.ToString().Contains(expected3));
      Assert.IsTrue(result.ToString().Contains(expected4));
    }
  }
}
