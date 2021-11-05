using ClassLibraryJson;
using Newtonsoft.Json.Linq;
using System;

namespace JsonArray
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      JObject result = HelperClass.FetchData("test");
      JToken token = HelperClass.FetchOneDatum("test");
      Display(token.ToString());
      Display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
