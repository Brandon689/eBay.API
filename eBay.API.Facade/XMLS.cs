using eBay.API.Models.SellerStore;
using System.Collections.Concurrent;
using System.Text;
using System.Xml.Serialization;

namespace eBay.API.Facade
{
    public class XMLS
    {
        RestClient restClient = new RestClient();
        private static readonly ConcurrentDictionary<Type, XmlSerializer> serializerCache = new ConcurrentDictionary<Type, XmlSerializer>();
        private string _eBayAuthToken;
        public XMLS(string token)
        {
            _eBayAuthToken = token;
        }

        public RequesterCredentials GetRequesterCredentials()
        {
            return new RequesterCredentials
            {
                eBayAuthToken = _eBayAuthToken
            };
        }

        public string SerializeToXml<T>(T requestObject, string namespaceUri = "urn:ebay:apis:eBLBaseComponents")
        {
            XmlSerializer serializer = serializerCache.GetOrAdd(typeof(T), t => new XmlSerializer(t));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("null", namespaceUri);

            using MemoryStream memoryStream = new MemoryStream();
            using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8, 1024, true))
            {
                serializer.Serialize(writer, requestObject, namespaces);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray()).Replace("xmlns:null", "xmlns");
        }

        public T DeserializeXmlToObject<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                throw new ArgumentNullException(nameof(xml), "The XML string cannot be null or empty.");
            }
            try
            {
                XmlSerializer serializer = serializerCache.GetOrAdd(typeof(T), t => new XmlSerializer(t));
                using StringReader reader = new StringReader(xml);
                return (T)serializer.Deserialize(reader);
            }
            catch (InvalidOperationException ex)
            {
                throw;
            }
        }

        public async Task<string> SendEbayRequest(string requestType, string xmlContent)
        {
            return await restClient.SendHttpRequest(requestType, xmlContent, HttpMethod.Post);
        }
    }
}

