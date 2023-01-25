namespace FikaAmazonAPI.Utils
{
    public class Region
    {
        private Region(string regionId, string hostUrl, string sandboxHostUrl, string regionName)
        {
            RegionId = regionId;
            HostUrl = hostUrl;
            SandboxHostUrl = sandboxHostUrl;
            RegionName = regionName;
        }
        public string RegionId { get; set; }
        public string RegionName { get; set; }
        public string HostUrl { get; set; }
        public string SandboxHostUrl { get; set; }


        public static Region NorthAmerica { get { return new Region("us-east-1", "https://sellingpartnerapi-na.amazon.com", "https://sandbox.sellingpartnerapi-na.amazon.com", "North America"); } }
        public static Region Europe { get { return new Region("eu-west-1", "https://sellingpartnerapi-eu.amazon.com", "https://sandbox.sellingpartnerapi-eu.amazon.com", "Europe"); } }
        public static Region FarEast { get { return new Region("us-west-2", "https://sellingpartnerapi-fe.amazon.com", "https://sandbox.sellingpartnerapi-fe.amazon.com", "Far East"); } }
    }
}
