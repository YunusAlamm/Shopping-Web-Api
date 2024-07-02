using Shopping_WebApi.Models;


public class SystemManager : User
{
    public enum Role
    {
        Basic, // Can perform basic actions
        Advanced, // Can perform all actions
                  
    }

    public List<StoreManager> StoreManagers { get; set; }

    public SystemManager()
    {
        StoreManagers = new List<StoreManager>();
    }

    public void AddStoreManager(StoreManager manager)
    {
        StoreManagers.Add(manager);
    }

    public void RemoveStoreManager(StoreManager manager)
    {
        StoreManagers.Remove(manager);
    }

    // Assign a role to a store manager
    public void AssignRoleToStoreManager(StoreManager manager, Role role = Role.Basic) // the default Role of store manager is basic, so they can only proccess orders
    {
        if (StoreManagers.Contains(manager))
        {
            manager.ManagerRole = role;
        }
    }

    // Check if a store manager has the required role to perform an action
    public bool CanPerformAction(StoreManager manager, Role requiredRole)
    {
        return manager.ManagerRole >= requiredRole;
    }
}
