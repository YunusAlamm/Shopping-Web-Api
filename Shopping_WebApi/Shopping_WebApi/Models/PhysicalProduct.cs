namespace Shopping_WebApi.Models
{
    public class PhysicalProduct : Product
    {
        public double Weight { get; set; }
        public string Dimensions { get; set; }
        public bool IsReturnable { get; set; }
    }
}
