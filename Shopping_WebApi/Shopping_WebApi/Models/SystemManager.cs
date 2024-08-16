using Shopping_WebApi.Models;


public class SystemManager : User
{
    public enum Role
    {
        Basic, // Can perform basic actions
        Advanced, // Can perform all actions
                  
    }

    public List<StoreManager> StoreManagers { get; set; }

   
}
