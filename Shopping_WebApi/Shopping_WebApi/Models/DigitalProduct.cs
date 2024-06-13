namespace Shopping_WebApi.Models
{
    public class DigitalProduct : Product
    {
        public string DigitalFormat { get; set; } // PDF,MP3,MP4,...
        public string DownloadLink { get; set; }
        public int LicenseKey { get; set; }
    }
}
