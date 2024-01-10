using Newtonsoft.Json.Linq;


namespace APIAutomationProject.Utilities
{
    public class TestDataReader
    {
        public static string GetTestData(string tokenName, string filePath)
        {
            try
            {
                var testDataDetails = File.ReadAllText(filePath);

                var testDataToken = JToken.Parse(testDataDetails);

                return testDataToken.SelectToken(tokenName).Value<string>();
            }
            catch (Exception ex)
            {
                throw new Exception("Required file not found", ex);
            }
            
        }

        public static string GetPayloadFromTestData(string tokenName,  string filePath)
        {
            try
            {
                var testDataDetails = File.ReadAllText(filePath);

                var testDataToken = JToken.Parse(testDataDetails);

                return testDataToken.SelectToken(tokenName).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Required file not found", ex);
            }
                       
        }
    }
}
