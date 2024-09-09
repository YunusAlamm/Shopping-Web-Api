namespace Shopping_WebApi.Core.Entities
{
    public class DigitalProduct : Product
    {
        public string DigitalFormat { get; set; } 
        public string Genre { get; set; }
        public string DownloadLink { get; set; }

    }
}
