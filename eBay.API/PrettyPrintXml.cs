using System.Xml.Linq;

namespace eBay.API.Test
{
    public static class Pretty
    {
        public static string PrettyPrintXml(string xmlString)
        {
            try
            {
                // Load the XML string into an XDocument
                XDocument doc = XDocument.Parse(xmlString);
                // Return the formatted string
                return doc.ToString();
            }
            catch (Exception ex)
            {
                // Handle or log the error
                Console.WriteLine("Error formatting XML: " + ex.Message);
                return xmlString; // Optionally return the original string on error
            }
        }

        public static void Lock(string filename, string contents)
        {
            File.WriteAllText($"../../../{filename}.xml", PrettyPrintXml(contents));
        }
    }
}
