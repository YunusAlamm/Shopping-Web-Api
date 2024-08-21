namespace Shopping_WebApi.Core.Entities
{
    public class DigitalProduct : Product
    {
        public string DigitalFormat { get; set; } // PDF,MP3,MP4,...
        public string DownloadLink { get; set; }

    }
}
