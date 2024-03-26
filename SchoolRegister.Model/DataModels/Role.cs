using Microsoft.AspNetCore.Identity;

public class Role : IdentityRole<int>
{
    public virtual RoleValue RoleValue
    {
        get;
        set;
    }

    public Role() : base()
    {
        RoleValue = RoleValue.User;
    }

    public Role(string name, RoleValue roleValue) : base(name)
    {
        RoleValue = roleValue;
    }
}
