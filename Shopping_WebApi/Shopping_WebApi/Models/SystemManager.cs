namespace Shopping_WebApi.Models
{
    public class SystemManager : User
    {
        public List<StoreManager> StoreManagers { get; set; }
        public SystemManager() 
        {
            StoreManagers = new List<StoreManager>();
        }
        public void AddStoreManager(StoreManager manager) { StoreManagers.Add(manager); }
        public void RemoveStoreManager(StoreManager manager) { StoreManagers.Remove(manager); }

    }
}
