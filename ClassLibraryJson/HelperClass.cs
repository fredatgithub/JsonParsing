using Newtonsoft.Json.Linq;
using System.IO;

namespace ClassLibraryJson
{
  public static class HelperClass
  {
    public static JObject FetchData(string testMethodName)
    {
      string jsonString = GetFileContent("sampleTest.txt");

      JObject obj = JObject.Parse(jsonString);
      JArray jsonArray = JArray.Parse(obj[testMethodName].ToString());

      JObject jObject = new JObject(new JProperty("test", jsonArray));

      return jObject;
    }

    public static JToken FetchOneDatum(string testMethodName)
    {
      string jsonString = GetFileContent("sampleTest.txt");
      JObject obj = JObject.Parse(jsonString);
      JArray jsonArray = JArray.Parse(obj[testMethodName].ToString());
      return jsonArray[0];
    }

    public static string GetFileContent(string filePath)
    {
      string result = string.Empty;
      using (StreamReader streamReader = new StreamReader(filePath))
      {
        result = streamReader.ReadToEnd();
      }

      return result;
    }
  }
}
