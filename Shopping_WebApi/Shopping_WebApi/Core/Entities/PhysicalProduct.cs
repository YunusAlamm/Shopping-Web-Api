namespace Shopping_WebApi.Core.Entities
{
    public class PhysicalProduct : Product
    {
        public double Weight { get; set; }
        public string Dimensions { get; set; }
        public bool IsReturnable { get; set; }
    }
}
